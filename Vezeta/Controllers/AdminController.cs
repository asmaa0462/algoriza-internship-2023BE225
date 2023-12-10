using AutoMapper;
using Azure.Core;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using NuGet.Versioning;
using RepositoryL.Data;
using ServiceL;
using ServiceL.Interface;
using ServiceL.UnitOfWork.UnitOfWork;
using System.Drawing;
using System.Runtime.ExceptionServices;
using static Vezeta.API.Controllers.DoctorController;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
       private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unit;
        public AdminController(AppDbContext context, IUnitOfWork unit,IMapper mapper)
        {
            
            _mapper = mapper;
            _context = context;
            _unit = unit;
            
            
        }

        //Get All Doctor
        [Authorize(Roles = "Admin")]
        [HttpGet("{GetAllDoctors}")]
        public async Task<IActionResult> GetALlDoctor([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize ,filter.Search);
            await _unit._doctor.GetAllAsync();
            return Ok();
        }
        //Get Doctor By ID
        [Authorize(Roles = "Admin")]
        [HttpGet("{GetDoctorById}")]
        public async Task<IActionResult> GetDoctorById(int id)
        {
            var result = _unit._doctor.GetbyId(id);
            return Ok(result);
        }
        //Add Doctor
        [Authorize(Roles = "Admin")]
        [HttpPost("AddDoctor")]
        public async Task<IActionResult> AddDoctor([FromBody] GetDoctorsDto doctor)
        {
            await _context.AddAsync(doctor);
            await _unit.SaveAsync();
            return Ok(true);
        }
        //Edit Doctor
        [Authorize(Roles = "Admin")]
        [HttpPut("EditDoctor")]
        public async Task<IActionResult> EditDoctor([FromBody] GetDoctorsDto updateddoctor)
        {
            var r = await _unit._doctor.FindAll().FirstOrDefaultAsync(i => i.Email == updateddoctor.Email);
            if (r is null)
            {
                return NotFound();
            }
            _mapper.Map(updateddoctor, r);
            await _unit.SaveAsync();
            return Ok("Update");
        }
        //DeleteDoctor
        [Authorize(Roles = "Admin")]
        [HttpDelete("DeleteDoctor")]
        public async Task<IActionResult> DeleteDoctor(int id)
        {
            var doct = await _unit._doctor.FindAll().FirstOrDefaultAsync(i => i.Id == id);
            if (doct is null)
            {
                return NotFound("Doctor Not Found");
            }
            _unit._doctor.Delete(doct);
            await _context.SaveChangesAsync();
            return Ok("Delete");
        }
        
        //GetAllPatient
        [Authorize(Roles = "Admin")]
        [HttpGet("{GetAllPatients}")]
        public async Task<IActionResult> GetALlPatients([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter.Search);
            await _unit._patient.GetAllAsync();
            return Ok();
        }

        //Get PatientById
        [Authorize(Roles = "Admin")]
        [HttpGet("{GetPatientById}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            await _unit._patient.GetbyIdAsync(id);
            return Ok();
        }
        //AddDiscount
        [Authorize(Roles = "Admin")]
        [HttpPost("{AddDiscount}")]
        public async Task<IActionResult> AddDiscount([FromBody] UpdateDiscountDto discount)
        {
            _context.AddAsync(discount);
            await _unit.SaveAsync();
            return Ok();
        }
        //UpdateDiscount
        [Authorize(Roles = "Admin")]
        [HttpPut("{UpdateDiscount}")]
        public async Task<IActionResult> UpdateDiscount([FromBody] UpdateDiscountDto discount)
        {
            var res =  _unit._discount.FindAll().FirstOrDefaultAsync(i => i.discountId == discount.Discount_id);
            if (res is null)
            {
                return NotFound();
            }
            _mapper.Map(discount, res);
            await _unit.SaveAsync();
            return Ok();
        }

        //DeleteDiscount
        [Authorize(Roles = "Admin")]
        [HttpDelete("{DeleteDiscount}")]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var q = _unit._discount.GetbyIdAsync(id);
            if (q is null)
            {
                return NotFound("Doctor Not Found");
            }
            _context.Remove(q);
            await _unit.SaveAsync();
            return Ok(true);
        }
        //DeactiveDiscount
        [Authorize(Roles = "Admin")]
        [HttpPut("{DeactiveDiscount}")]
        public async Task<IActionResult> DeactiveDiscount(int id)
        {
            var doct = _unit._discount.GetbyIdAsync(id);
            if (doct is null)
            {
                return NotFound("Discount Not Found");
            }
            var discountDto = new UpdateDiscountDto();
            discountDto.DiscountState = DiscountState.Deactive;
            await _unit.SaveAsync();
            return Ok(true);

        }
 
        //NumofPatient
        [Authorize(Roles = "Admin")]
        [HttpGet("numberofpatient")]
        public  ActionResult GetPatientNum()
        {
            _unit._patient.FindAll();
            return Ok();
        }
        //numofRequst
        [Authorize(Roles = "Admin")]
        [HttpGet("{NumberOfReqursted}")]
        public async Task<IActionResult> GetRequests()
        {
            await _unit._patient.FindAll().OrderBy(i => i.NumberofRequest).CountAsync();

            return Ok();
        }
        
        //top 5 Specialization
        [Authorize(Roles = "Admin")]
        [HttpGet("Top 5 Doctors")]
        public async Task<IActionResult> GetFive()
        {
            var list =
               await _unit._doctor.FindAll().OrderByDescending(m => m.numberOfRequests).ThenBy(l => l.SpecializationId)
                .Take(5).ToListAsync();
            return Ok(list);
        }
        //NumofDoctor
        [Authorize(Roles = "Admin")]
        [HttpGet("NumberOfDoctors")]
        public async Task <IActionResult> GetDoctorNum()
        {
            var number = await _unit._doctor.FindAll().CountAsync();
            return Ok(number);
        }
        //top 10 doctors
        [Authorize(Roles = "Admin")]
        [HttpGet("Top 10 Doctors")]
        public async Task<IActionResult> GetTen()
        {
            var List = await _unit._doctor.FindAll().OrderByDescending(t =>t.numberOfRequests).Take(10).ToListAsync();
            return Ok(List);
        }
    }
}


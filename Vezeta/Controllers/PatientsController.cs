using Domain.DTO;
using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RepositoryL.Data;
using ServiceL;
using ServiceL.Interface;
using ServiceL.UnitOfWork.UnitOfWork;
using System.Drawing.Printing;
using static Vezeta.API.Controllers.DoctorController;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IUnitOfWork _unit;
        private readonly AppDbContext _context;
        
        public PatientsController(IUnitOfWork unit , AppDbContext context)
        {
            _context = context;
            _unit = unit;
            
        }
        //Gethisbooking
        [Authorize(Roles = "Patient")]
        [HttpGet("Search by Page/PageSize/Search")]
        public async Task<ActionResult> SearchbyFilter([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter.Search);
            var response = await _unit._doctor.GetAllAsync();
            return Ok(response);
        }
        
        //Search by time And Discount Copoun
        [Authorize(Roles = "Patient")]
        [HttpGet("SearchByTimeId And Copoun")]
        public ActionResult Searchbytime(int timeid, UpdateDiscountDto discount)
        {
            if (!_unit._time.FindAll().Any())
            {
                return NotFound(false);
            }
            else if (discount.DiscountState == DiscountState.Deactive || !_unit._time.FindAll().Any())
            {
                return NotFound(false);
            }
            _unit._time.FindAll().FirstOrDefault(t => t.timeId == timeid);
            return Ok(true);
        }

        //Search by Doctor Name
        [Authorize(Roles = "Patient")]
        [HttpGet("SearchByDoctorName")]
        public async Task<ActionResult> SearchByDoctorName(string name)
        {
            var q = string.IsNullOrEmpty(name);
            if (q)
            {
                return NotFound("You don't enter Any Name");
            }
            else
            {

                var book = new Booking();
                if (book.BookState != BookState.Pending)
                {
                    _unit._doctor.GetAll();
                    _unit._time.GetAll();
                    _unit._appoint.GetAll();
                }
            }
            return Ok();

        }
        //Booking Create 
        [Authorize(Roles = "Patient")]
        [HttpGet("Booking")]
        public async Task<ActionResult> CreateRequest(GetBookingDTO book)
        {
            await _context.AddAsync(book);
            book.BookState = BookState.Pending;//pending
            if (book.BookState == 0)
                _unit._patient.AddNumberRequest();
            await _unit.SaveAsync();
            return Ok("You booked Appointment");
        }
        //Booking Cancel
        [Authorize(Roles = "Patient")]
        [HttpDelete("Cancel")]
        public async Task<ActionResult> CancelRequest(int id)
        {
            var book = new UpdateBookingDto();
            if (id == book.bookId)
            {
                _context.Remove(book);
                book.BookState = BookState.Cancel;
            }
            await _unit.SaveAsync();
            return Ok(false);
        }
        //GetAllBooking
        [HttpGet("GetAllBooking")] 
        public async Task<ActionResult> GetAllBooking([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize, filter.Search);
            var appoint = new GetAppointmentDto();
            var Result = await _unit._appoint.GetAllAsync();
            return Ok(Result);
        }
   
    }
}

using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.Entities.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Core;
using NuGet.Protocol.Core.Types;
using RepositoryL.Data;
using ServiceL;
using ServiceL.Interface;
using ServiceL.UnitOfWork.UnitOfWork;
using System;
using System.Net.Sockets;
using System.Security.Claims;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unit;
        public DoctorController(AppDbContext context,IUnitOfWork unit)
        {
            _context = context;
            _unit = unit;
        }
       //Add Appointment
        [Authorize(Roles = "Doctor")]
        [HttpPost("Confirm Booking")]
        public async Task<ActionResult> CreateAppointment([FromBody] CreateAppointmentDto appointment)
        {
            await _context.AddAsync(appointment);
            await _unit.SaveAsync();
            return Ok(true);
        }
        //UpdateAppointment
        [Authorize(Roles = "Doctor")]
        [HttpPut("Confirm Booking")]
        public async Task<ActionResult> UpdateAppointment(int timeid)
        {
            var book = new GetBookingDTO();
            var t = new UpdateTimeDto();
            if (timeid == t.timeId &&!( book.BookState == BookState.Pending))
                _context.Update(t);
            await _unit.SaveAsync();
            return Ok(true);
        }
        //Delete Appointment
        [Authorize(Roles = "Doctor")]
        [HttpDelete("Confirm Booking")]
        public async Task<ActionResult> DeleteAppointment(int timeid)
        {
            var book = new GetBookingDTO();
            var t = new UpdateTimeDto();
            if (timeid == t.timeId && !(book.BookState == BookState.Pending))
            {
                _context.Remove(timeid);
                _context.Update(t);
            }
            await _context.SaveChangesAsync();
            return Ok(true);
        }
        
        //confirm to Complete
        [Authorize(Roles = "Doctor")]
        [HttpPut("ConfirmBooking")]
        public  ActionResult ConfirmRequest(int bookid)
        {
            var book = new Booking();
            if (_unit._booking.GetbyId(bookid) is null)
            {
                return (NotFound());
            }
            book.BookState = BookState.Complete;
            _context.Update(book);
            _unit.Save();
            return Ok();
        }
        //GetAll
        [Authorize(Roles = "Doctor")]
        [HttpGet("GetAllBooking")]
        public async Task<IActionResult> Filter([FromQuery] PaginationFilter filter)
        {
            var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize , filter.Date);
            var resposne = await _unit._patient.FindAll().ToListAsync();
            return Ok(resposne);
        }
    }
}
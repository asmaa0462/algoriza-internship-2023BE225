using Domain.Entities;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryL.Data;
using System.Security.Cryptography;
using Domain.DTO;
using System.Text;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AcountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        
        public AcountController(AppDbContext context,UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
          
        }

        //Register
        [Authorize(Roles = "Patient")]
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequestDto request)
        {
            if (_context.Users.Any(u => u.Email == request.Email))
            {
                return BadRequest("User already exists.");
            }
            
            var user = new User
            {
                FirstName = request.FirstName,
                LastName=request.LastName,
                Gender = request.Gender,
                DateBirth = request.DateBirth,
                Password = request.Password,
                image =request.image,
                Phone = request.Phone,
                Email = request.Email
            };
            _context.Add(user);
            await _userManager.AddToRoleAsync(user, "Patient");
            await _context.SaveChangesAsync();

            return Ok("User successfully created!");
        }
        //Login
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequestDto request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }
            if (user.PasswordHash != request.Password) 
            {
                return BadRequest("Password is incorrect.");
            }
            return Ok($"Welcome back, {user.Email}");
        }
    }
}

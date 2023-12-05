using Core.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationController : ControllerBase
    {
        private readonly IBaseRepository<Specialization> _specializationRepository;
        public SpecializationController(IBaseRepository<Specialization> specializationRepository)
        {
            _specializationRepository = specializationRepository;
        }
        [HttpGet]
        public IActionResult GetById() 
        {
            return Ok(_specializationRepository.GetById(1));
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_specializationRepository.GetAll());
        }
        //still need to change
        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_specializationRepository.Find(b=>b.SpecializationName == "Oncology"));
        }
    }
}

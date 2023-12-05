using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryL.Interfaces;

namespace Vezeta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecializationController : ControllerBase
    {
        private readonly IBaseRepository<Specialization> _specializationRepository;
        public SpecializationController(IBaseRepository<Specialization> baseRepository)
        {

            _specializationRepository = baseRepository;
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
            return Ok(_specializationRepository.Find(b => b.SpecializationName == "Oncology"));
        }
        [HttpDelete("DeleteById")]
        public IActionResult DeleteById()
        {
            return Ok(_specializationRepository.Find(b => b.SpecializationName == "Oncology"));
        }
        

    }
}

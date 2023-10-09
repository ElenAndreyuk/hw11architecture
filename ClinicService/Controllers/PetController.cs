using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models.Requests;
using WebApplication10.Models;
using WebApplication10.Services;
using ClinicService.Models;
using ClinicService.Services;
using Swashbuckle.AspNetCore.Annotations;

namespace WebApplication10.Controllers
{
    public class PetController : Controller
    {


        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        [HttpPost("create")]
        [SwaggerOperation(OperationId = "PetCreate")]
        public IActionResult Create([FromBody] CreatePetRequest createRequest)
        {
            int res = _petRepository.Create(new Pet
            {
                ClientId = createRequest.ClientId,
                Name = createRequest.Name,
                Birthday = createRequest.Birthday,
            });
            return Ok(res);
        }

        [HttpPut("update")]
        [SwaggerOperation(OperationId = "PetUpdate")]
        public IActionResult Update([FromBody] UpdatePetRequest updateRequest)
        {
            int res = _petRepository.Update(new Pet
            {
                PetId = updateRequest.PetId,
                ClientId = updateRequest.ClientId,
                Name = updateRequest.Name,
                Birthday = updateRequest.Birthday
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        [SwaggerOperation(OperationId = "PetDelete")]
        public IActionResult Delete([FromQuery] int petId)
        {
            int res = _petRepository.Delete(petId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        [SwaggerOperation(OperationId = "PetGetAll")]
        public IActionResult GetAll()
        {
            return Ok(_petRepository.GetAll());
        }


        [HttpGet("get/{petId}")]
        [SwaggerOperation(OperationId = "PetGetById")]
        public IActionResult GetById([FromRoute] int petId)
        {
            return Ok(_petRepository.GetById(petId));
        }
    }
}


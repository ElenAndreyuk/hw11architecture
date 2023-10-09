using Microsoft.AspNetCore.Mvc;
using WebApplication10.Models.Requests;
using WebApplication10.Models;
using WebApplication10.Services;

namespace WebApplication10.Controllers
{
    public class ConsultationController : Controller
    {

        private readonly IConsultationRepository _consultationRepository;

        public ConsultationController(IConsultationRepository consultationRepository)
        {
            _consultationRepository = consultationRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] CreateConsultationRequest createRequest)
        {
            int res = _consultationRepository.Create(new Consultation
            {
                ClientId = createRequest.ClientId,
                PetId = createRequest.PetId,
                ConsultationDate = createRequest.ConsultationDate,
                Description = createRequest.Description
                
            });
            return Ok(res);
        }

        [HttpPut("update")]
        public IActionResult Update([FromBody] UpdateConsultationRequest updateRequest)
        {
            int res = _consultationRepository.Update(new Consultation
            {
                ConsultationId = updateRequest.ConsultationId,
                ClientId = updateRequest.ClientId,
                PetId = updateRequest.PetId,
                ConsultationDate = updateRequest.ConsultationDate,
                Description = updateRequest.Description
            });
            return Ok(res);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromQuery] int consultationId)
        {
            int res = _consultationRepository.Delete(consultationId);
            return Ok(res);
        }

        [HttpGet("get-all")]
        public IActionResult GetAll()
        {
            return Ok(_consultationRepository.GetAll());
        }


        [HttpGet("get/{petId}")]
        public IActionResult GetById([FromRoute] int consultationId)
        {
            return Ok(_consultationRepository.GetById(consultationId));
        }
    }
}

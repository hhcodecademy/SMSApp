using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMSApp.BLL.Services.Interfaces;
using SMSApp.DAL.Dtos;
using SMSApp.DAL.Models;

namespace SMSApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IGenericService<StudentDto, Student> _service;
        private readonly ILogger<StudentsController> _logger;
        public StudentsController(IGenericService<StudentDto, Student> service, ILogger<StudentsController> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpPost]
        public  ActionResult<StudentDto> Create(StudentDto itemDto)
        {
            _logger.LogInformation("Seri Log is Working");
            var response =  _service.Create(itemDto);
            return Ok(response);
        }

    }
}

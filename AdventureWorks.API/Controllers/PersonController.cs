using AdventureWorks.Common.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AdventureWorks.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var response = await _personService.GetPersonDetails();

                if (response == null)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetVersion2()
        {
            try
            {
                var response = await _personService.GetPersonDetails();

                if (response == null)
                    return NotFound();

                var wrapper = new
                {
                    response.Count,
                    Persons = response
                };

                return Ok(wrapper);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpGet]
        [Route("{personId:int}")]
        public async Task<IActionResult> Get(int personId)
        {
            try
            {
                var response = await _personService.GetPersonDetail(personId);

                if (response == null)
                    return NotFound();

                return Ok(response);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }
    }
}

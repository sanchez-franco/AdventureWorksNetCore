using AdventureWorks.Common.Interface;
using AdventureWorks.Common.Model;
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
        public async Task<ActionResult<PersonDetail[]>> Get()
        {
            try
            {
                var response = await _personService.GetPersonDetails();

                if (response == null)
                    return NotFound();

                return response;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpGet]
        public async Task<ActionResult<dynamic>> GetVersion2()
        {
            try
            {
                var response = await _personService.GetPersonDetails();

                if (response == null)
                    return NotFound();

                var wrapper = new
                {
                    response.Length,
                    Persons = response
                };

                return wrapper;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }

        [HttpGet]
        [Route("{personId:int}")]
        public async Task<ActionResult<PersonDetail>> Get(int personId)
        {
            try
            {
                var response = await _personService.GetPersonDetail(personId);

                if (response == null)
                    return NotFound();

                return response;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.ToString());
            }
        }
    }
}

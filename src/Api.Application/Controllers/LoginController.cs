using System.Net;
using System;
using System.Threading.Tasks;
using Api.Domain.Interfaces.Service.User;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Dtos;
using Microsoft.AspNetCore.Authorization;

namespace Api.Application.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto loginDto, [FromServices] ILoginService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (loginDto == null)
            {
                return BadRequest();
            }

            try
            {
                var result = await service.FindyByLogin(loginDto);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
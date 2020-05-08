using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UserController: Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch(Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpPost("userverify")]
        public ActionResult UserVerify([FromBody] User user)
        {
            try
            {
                var userReturn = _userRepository.GetUser(user.Email, user.Password);
                if(userReturn != null)
                {
                    return Ok(userReturn);
                }
                return NotFound("Invalid user or password");
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.ToString());
            }
        }
    }
}

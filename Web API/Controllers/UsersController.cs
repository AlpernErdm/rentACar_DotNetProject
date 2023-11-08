using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getall")]
        public IActionResult GetCar()
        {
            var res = _userService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }

            return BadRequest(res);
        }
    
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _userService.GetById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var res = _userService.Add(user);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPut("update")]
        public IActionResult Update(User user)
        {
            return Ok(_userService.Update(user));
        }

        [HttpDelete("delete")]
        public IActionResult Delete(User user)
        {
            return Ok(_userService.Delete(user));
        }
    }
}


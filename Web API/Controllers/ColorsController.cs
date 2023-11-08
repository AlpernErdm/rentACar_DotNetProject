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
    public class ColorsController : ControllerBase
    {
        IColorService _colorservice;

        public ColorsController(IColorService colorservice)
        {
            _colorservice = colorservice;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var res = _colorservice.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _colorservice.GetById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            var res = _colorservice.Add(color);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPut("update")]
        public IActionResult Update(Color color)
        {
            return Ok(_colorservice.Update(color));
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Color color)
        {
            return Ok(_colorservice.Remove(color));
        }
    }
}

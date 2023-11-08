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
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet("getall")]
        public IActionResult GetCar()
        {
            var res = _carService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }

            return BadRequest(res);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _carService.GetById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var res = _carService.Add(car);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            return Ok(_carService.Update(car));
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            return Ok(_carService.Delete(car));
        }
    }
    
}

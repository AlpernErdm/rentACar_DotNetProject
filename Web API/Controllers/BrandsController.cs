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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getall")]
        public IActionResult GetBrand()
        {
            var res = _brandService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _brandService.GetById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var res = _brandService.Add(brand);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);

        }
        [HttpPut("update")]
        public IActionResult Update(Brand brand )
        {
            return Ok(_brandService.Update(brand));
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            return Ok(_brandService.Remove(brand));
        }
    }
}

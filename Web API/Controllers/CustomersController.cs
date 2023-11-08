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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var res = _customerService.GetAll();
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            var res = _customerService.Add(customer);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var res = _customerService.GetById(id);
            if (res.Success)
            {
                return Ok(res);
            }
            return BadRequest(res);
        }
        [HttpPut("update")]
        public IActionResult Update(Customer customer)
        {
            return Ok(_customerService.Update(customer));
        }

        [HttpDelete("delete")]
        public IActionResult Delete(Customer customer)
        {
            return Ok(_customerService.Delete(customer));
        }
    }
}

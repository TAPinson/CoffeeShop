﻿using CoffeeShop.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoffeeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {

        private readonly CoffeeRepository _coffeeRepository;

        public CoffeeController(IConfiguration configuration)
        {
            _coffeeRepository = new CoffeeRepository(configuration);
        }



        // GET: api/<CoffeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_coffeeRepository.GetAll());
            //return new string[] { "value1", "value2" };
        }

        // GET api/<CoffeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_coffeeRepository.GetCoffeeById(id));
        }

        // POST api/<CoffeeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CoffeeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CoffeeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

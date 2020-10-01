using Microsoft.AspNetCore.Mvc;
using MySample.API.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MySample.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;
        }
        //Get api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var  values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        //Get api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(v => v.id == id);
            return Ok(value);
        }
        //Post api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {}
        //Put api/values/5
        [HttpPut]
        public void Put(int id,[FromBody] string value)
        {}

    }
}
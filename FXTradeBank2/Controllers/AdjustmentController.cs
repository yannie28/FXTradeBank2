using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FXTradeBank2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdjustmentController : ControllerBase
    {
        public int minPPU;
        // GET: api/Adjustment
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Adjustment/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/Adjustment
        [HttpPost]
        public void Post([FromBody] int value)
        {
            minPPU = value;
        }

        // PUT: api/Adjustment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

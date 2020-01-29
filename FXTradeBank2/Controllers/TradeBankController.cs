using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FXTradeBank2.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FXTradeBank2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TradeBankController : ControllerBase
    {
        // GET: api/TradeBank
        [HttpGet]
        public IEnumerable<TradeBankModel> Get()
        {
            List<TradeBankModel> offer = new List<TradeBankModel>();

            offer.Add(new TradeBankModel()
            {
                Id = "1",
                SourceCurrency = "SGD",
                DestinationCurrency = "USD",
                Amount = 1000,
                Status = "Successful"
            }
            );

            offer.Add(new TradeBankModel()
            {
                Id = "2",
                SourceCurrency = "SGD",
                DestinationCurrency = "GBP",
                Amount = 2000,
                Status = "Failed"
            }
            );

            return offer;
        }

        // GET: api/TradeBank/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/TradeBank
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TradeBank/5
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

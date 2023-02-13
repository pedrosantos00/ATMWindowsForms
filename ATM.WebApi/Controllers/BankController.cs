using ATM.Domain;
using ATM.Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private BankService _bankService;

        public BankController(BankService repository)
        {
            _bankService = repository;
        }


        // GET: api/<BankController>
        [HttpGet]
        public IEnumerable<Bank> Get(string? searchfilter = null)
        {
            return _bankService.Search(searchfilter);
        }

        // GET api/<BankController>/5
        [HttpGet("{id}")]
        public Bank Get(int id)
        {
            return _bankService.GetById(id);
        }

        // POST api/<BankController>
        [HttpPost]
        public int Post([FromBody] Bank bank)
        {
            int id = _bankService.Create(bank);

            return id;
        }

        // PUT api/<BankController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Bank bank)
        {
            _bankService.Update(bank);
        }

        // DELETE api/<BankController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _bankService.Delete(id);
        }
    }
}

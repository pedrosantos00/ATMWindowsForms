using ATM.Domain;
using ATM.Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {

        private TransactionService _transactionService;

        public TransactionController(TransactionService repository)
        {
            _transactionService = repository;
        }

        // GET: api/<TransactionController>
        [HttpGet]
        public IEnumerable<Transaction> Get(string? searchfilter = null)
        {
            return _transactionService.Search(searchfilter);
        }

        // GET api/<TransactionController>/5
        [HttpGet("{id}")]
        public Transaction Get(int id)
        {
            return _transactionService.GetById(id);
        }

        // POST api/<TransactionController>
        [HttpPost]
        public int Post([FromBody] Transaction transaction)
        {
            int id = _transactionService.Create(transaction);

            return id;
        }

        // PUT api/<TransactionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Transaction transaction)
        {
            _transactionService.Update(transaction);
        }

        // DELETE api/<TransactionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _transactionService.Delete(id);
        }
    }
}

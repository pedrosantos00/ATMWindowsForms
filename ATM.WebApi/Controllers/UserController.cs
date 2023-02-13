using ATM.Domain;
using ATM.Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ATM.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private UserService _userService;

        public UserController(UserService repository)
        {
            _userService = repository;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get(string? searchfilter = null)
        {
            return _userService.Search(searchfilter);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.GetById(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public int Post([FromBody] User user)
        {
            int id = _userService.Create(user);

            return id;
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            _userService.Update(user);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _userService.Delete(id);
        }
    }
}

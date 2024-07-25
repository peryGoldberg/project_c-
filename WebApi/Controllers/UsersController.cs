using Dal_Repository;
using Dal_Repository.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new Bl_Services.UserBL().GetAll(); 
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
          return new Bl_Services.UserBL().Get(id);
            
        }

        //[HttpGet]
        //public object GetSpec()
        //{
        //    return new Bl_Services.UserBL().GetAll().Select(d=> new {d.Email,d.UserId});

        //}

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User value)
        {
            new Bl_Services.UserBL().Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            new Bl_Services.UserBL().Update(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new Bl_Services.UserBL().Delete(id);
        }
    }
}

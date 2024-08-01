
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IBL.Ibl IUserbl;

        public UsersController(IBL.Ibl ibl)
        {
            IUserbl = ibl;
        }


        // GET: api/<UsersController>
        [HttpGet]
        //
        public IEnumerable<object> Get()
        {
            return IUserbl.GetAll(); 
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public object Get(int id)
        {
          return IUserbl.Get(id);
            
        }

        //[HttpGet]
        //public object GetSpec()
        //{
        //    return new Bl_Services.UserBL().GetAll().Select(d=> new {d.Email,d.UserId});

        //}

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] object value)
        {
            IUserbl.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] object user)
        {
            IUserbl.Update(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            IUserbl.Delete(id);
        }
    }
}

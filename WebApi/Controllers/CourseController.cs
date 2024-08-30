
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly IBL.ICourseBL ICourseBL;

        public CourseController(IBL.ICourseBL ibl)
        {
            ICourseBL = ibl;
        }


        // GET: api/<UsersController>
        [HttpGet]
        //
        public IEnumerable<CourseDTO> Get()
        {
            return ICourseBL.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public CourseDTO Get(int id)
        {
            return ICourseBL.Get(id);

        }

        //[HttpGet]
        //public object GetSpec()
        //{
        //    return new Bl_Services.UserBL().GetAll().Select(d=> new {d.Email,d.UserId});

        //}

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] CourseDTO value)
        {
            ICourseBL.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CourseDTO user)
        {
            ICourseBL.Update(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ICourseBL.Delete(id);
        }
    }
}

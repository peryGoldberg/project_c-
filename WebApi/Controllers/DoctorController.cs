using Dal_Repository.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return new Bl_Services.DoctorBL().GetAll();
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public Doctor Get(int id)
        {
            return new Bl_Services.DoctorBL().Get(id);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor value)
        {
            new Bl_Services.DoctorBL().Add(value);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor value)
        {
            new Bl_Services.DoctorBL().Update(value);
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            new Bl_Services.DoctorBL().Delete(id);
        }
    }
}

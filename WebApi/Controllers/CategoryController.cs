﻿
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IBL.ICategoryBL ICategorybl;

        public CategoryController(IBL.ICategoryBL ibl)
        {
            ICategorybl = ibl;
        }


        // GET: api/<UsersController>
        [HttpGet]
        //
        public IEnumerable<CategoryDTO> Get()
        {
            return ICategorybl.GetAll();
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public CategoryDTO Get(int id)
        {
            return ICategorybl.Get(id);

        }

        //[HttpGet]
        //public object GetSpec()
        //{
        //    return new Bl_Services.UserBL().GetAll().Select(d=> new {d.Email,d.UserId});

        //}

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] CategoryDTO value)
        {
            ICategorybl.Add(value);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CategoryDTO user)
        {
            ICategorybl.Update(user);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ICategorybl.Delete(id);
        }
    }
}
using AutoMapper;
using DepartmentApi.Model;
using DepartmentDatabase.DatabaseContext;
using DepartmentDatabase.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DepartmentApi.Controllers
{
    [Route("api/Staff/{firstname}/role")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        DepartmentContext _context = new DepartmentContext();
        private readonly IMapper _mapper;
        //private readonly LinkGenerator _linkGenerator;
        public RolesController(IMapper mapper)
        {
            _mapper = mapper;
           // _linkGenerator = linkGenerator;
        }
        // GET: api/<RolesController>
        [HttpGet]
        public ActionResult<Role> Get(string firstname)
        {
            var staff = _context.Staff.Where(s => s.FirstName == firstname).FirstOrDefault();
            var role = _context.Role.Where(s => s.Id == staff.RoleId).FirstOrDefault();
            return Ok(_mapper.Map<RoleModel>(role));
        }

        // GET api/<RolesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RolesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RolesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RolesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using DepartmentDatabase.DatabaseContext;
using DepartmentDatabase.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoMapper;
using DepartmentApi.Model;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DepartmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;
        public StaffController(IMapper mapper,LinkGenerator linkGenerator)
        {
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }
        DepartmentContext _context = new DepartmentContext();
        [HttpGet]
        public IActionResult GetStaff() {

            try { 
           

            //    var staff = _context.Staff.ToList();
            //    List<StaffModel> staffDetail = _mapper.Map<List<StaffModel>>(staff);
            //    return Ok(staffDetail);
                var query = _context.Staff.Include(r => r.Role).ToList();

                return Ok(_mapper.Map<List<StaffModel>>(query));


            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{firstname}")]
        public IActionResult GetStaffDetails(string firstName)
        {
            try
            {
                var data = _context.Staff.Where(s => s.FirstName == firstName).ToList();
                List<StaffModel> Staffdetail = _mapper.Map<List<StaffModel>>(data);
                return Ok(Staffdetail);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpPost]
        public IActionResult AddStaff(Staff staff)
        {
            var location = _linkGenerator.GetPathByAction("GetStaffDetails","Staff",new { firstName=staff.FirstName });
            try
            {
                _context.Staff.Add(staff);
                _context.SaveChanges();
                return Created(location,staff);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
            
        }

        [HttpPut("{id}")]       
        public IActionResult UpdateStaff(int id,StaffModel staff)
        {
            try
            {
                var getstaff = _context.Staff.Where(s => s.Id == id).FirstOrDefault();
                _mapper.Map(staff, getstaff);
                //_context.Entry(getstaff).State = EntityState.Modified;
                _context.SaveChanges();
                return this.StatusCode(StatusCodes.Status200OK, "Updated Staff");
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStaff(int id)
        {
            try
            {
                var Staff = _context.Staff.Where(s => s.Id == id).FirstOrDefault();
                var address = _context.Address.Where(s => s.StaffId == id).FirstOrDefault();
                _context.Address.Remove(address);
                _context.Staff.Remove(Staff);
                _context.SaveChanges();
                return this.StatusCode(StatusCodes.Status200OK, "Deleted");
            }
            catch (Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }
    }
}

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
        public ActionResult<List<StaffModel>> GetStaff() {

            try
            {


                //var staff = _context.Staff.ToList();
                //List<StaffModel> staffDetail = _mapper.Map<List<StaffModel>>(staff);
                //return Ok(staffDetail);
                var query = _context.Staff.Include(r => r.Role).ToList();
                //var querry1= (from Staff in _context.Set<Staff>()
                //             join Role in _context.Set<Role>() on Staff.RoleId equals Role.Id
                //             join Address in _context.Set<Address>() on Staff.Id equals Address.StaffId
                //             select new { Staff, Address,Role }).ToList();
                //var querry = _context.Staff.Include(r=>r.Role).Include(a=>a.)
                return Ok(_mapper.Map<List<StaffModel>>(query));


            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("search")]
        public ActionResult<List<StaffModel>> GetStaffDetails(string firstName ,string salary)
        {
            try
            {
                if (salary == null)
                {
                    var dataa = _context.Staff.Where(s => s.FirstName == firstName).Include(r => r.Role).ToList();
                    List<StaffModel> Staffdetails = _mapper.Map<List<StaffModel>>(dataa);
                    if (!Staffdetails.Any()) return NotFound();
                    return Ok(Staffdetails);
                }
                else  if (firstName==null)
                {
                    var dataaa = _context.Staff.Where(s => s.Salary == salary).Include(r => r.Role).ToList();
                    List<StaffModel> Staffdetailss= _mapper.Map<List<StaffModel>>(dataaa);
                    if (!Staffdetailss.Any()) return NotFound();
                    return Ok(Staffdetailss);
                }
                var data = _context.Staff.Where(s => s.FirstName == firstName).Where(s=>s.Salary==salary).Include(r => r.Role).ToList();
                List<StaffModel> Staffdetail = _mapper.Map<List<StaffModel>>(data);
                if (!Staffdetail.Any()) return NotFound();
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

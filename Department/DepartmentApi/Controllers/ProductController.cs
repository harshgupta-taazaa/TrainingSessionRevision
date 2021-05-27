using AutoMapper;
using DepartmentApi.Model;
using DepartmentDatabase.DatabaseContext;
using DepartmentDatabase.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DepartmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;
        public ProductController(IMapper mapper, LinkGenerator linkGenerator)
        {
            _mapper = mapper;
            _linkGenerator = linkGenerator;
        }
        DepartmentContext _context = new DepartmentContext();
        public IActionResult GetStaff()
        {

            try
            {

                var product = _context.Product.ToList();
                List<ProductModel> staffDetail = _mapper.Map<List<ProductModel>>(product);
                return Ok(staffDetail);



            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }

        [HttpGet("{ProductName}")]
        public IActionResult GetStaffDetails(string ProductName)
        {
            try
            {
                var data = _context.Product.Where(s => s.ProductName == ProductName).ToList();
                List<ProductModel> product = _mapper.Map<List<ProductModel>>(data);
                return Ok(product);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }


        [HttpPost]
        public IActionResult AddStaff(Product product)
        {
            
            try
            {
                _context.Product.Add(product);
                _context.SaveChanges();
                return Ok(product);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

        }
    }
}

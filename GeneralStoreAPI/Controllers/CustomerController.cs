using GeneralStoreAPI.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GeneralStoreAPI.Controllers
{
    public class CustomerController : ApiController
    {
        private readonly IdentityDbContext _context = new IdentityDbContext();
        // POST
        [HttpPost]
        public async Task<IHttpActionResult> CreateCustomer([FromBody] Customer model)
        {
            if (ModelState.IsValid)
            {
                _context.Customer.Add(model);
                await _context.SaveChangesAsync();
                return Ok("The customer was created.");
            }
            return BadRequest(ModelState);
        }
        

        // GET all customers
        [HttpGet]
        public async Task<IHttpActionResult> GetAllCustomers()
        {
            Customer customer = await _context.
        }

        // GET by Id
        [HttpGet]
        public async Task<IHttpActionResult> GetCustomerById([FromUri] int id)
        {
            Customer customer = await _context.

            if(customer != null)
            {
                return Ok(customer);
            }

            return NotFound();
        }

        // PUT by Id 
        [HttpPut]
        public async Task<IHttpActionResult> UpdateCustomer([FromUri] int id, [FromBody] Customer customer)
        {

        }

        // DELETE by Id
        [HttpDelete]

    }
}

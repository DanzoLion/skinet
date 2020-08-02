using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;                                                    // remove using API.Entities; using API.Data;     
using Core.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]                                                                                 // api attribute
    [Route("api/[controller]")]                                                               // required api route, this will find [controller] function
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task< ActionResult<List<Product>>> GetProducts()                // returns a  string as we don't have any data set yet
        {
            var products = await _context.Products.ToListAsync();                          // ToList() executes a select query and returns the result to var products and stores it there    

            return Ok(products);                                   
        }

        [HttpGet("{id}")]                                                                           // we need an id parameter so our controller know which HttpGet to retrieve
        public async Task <ActionResult<Product>> GetProduct(int id)
        {
            return await _context.Products.FindAsync(id);
        }
    }
}
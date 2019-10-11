using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_netcore.Models;
using App_netcore.Data;

namespace App_netcore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST: api/Api
        [HttpPost]
        public async Task<ActionResult<ContactoApi>> PostContactoApi(ContactoApi item)
        {

            return Ok();
        }
    }
}
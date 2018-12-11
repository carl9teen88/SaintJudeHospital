using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaintJudeHospital.Data.Entity;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SaintJudeHospital.APIs
{
    [Authorize]
    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<string> Users()
        {
            return _context.Users.Select(u => u.UserName).ToList();
        }

        [AllowAnonymous]
        [HttpGet]
        public IEnumerable<string> Login()
        {
            return null;
        }

        [AllowAnonymous]
        [HttpPost]
        public string Login([FromBody] string username, string password)
        {
            return "value";
        }
                
        [HttpGet]
        public void Logout()
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}

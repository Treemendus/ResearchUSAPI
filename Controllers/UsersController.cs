using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResearchUSAPI.Models;
using ResearchUSAPI;

namespace ResearchUSAPI.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly ResearchUSContext _context;

        public UsersController(ResearchUSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> Get(int id)
        {
            return _context.Users.ToList();   
        }

        [HttpGet("{id}")]
        public User GetByID(int id)
        {
            return _context.Users.FirstOrDefault(o => o.id == id);
        }

        [HttpPost]
        public void Create()
        {
            User u = new User();
            u.first_name = $"User";
            u.last_name = $"{_context.Users.Count() + 1}";
            u.email = $"{u.last_name}, {u.first_name}";
            u.created_on = DateTime.Now;

            _context.Users.Add(u);
            _context.SaveChanges();
        }
    }
}

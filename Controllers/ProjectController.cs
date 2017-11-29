using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResearchUSAPI.Models;
using ResearchUSAPI;
using Newtonsoft.Json.Linq;

namespace ResearchUSAPI.Controllers
{
    [Route("[controller]")]
    public class ProjectController : Controller
    {
        private readonly ResearchUSContext _context;

        public ProjectController(ResearchUSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<Project> Get()
        {
            return _context.Projects.ToList();   
        }

        [HttpGet("{id}")]
        public Project Get(int id)
        {
            return _context.Projects.FirstOrDefault(o => o.id == id);   
        }

        [HttpPost]
        public void Create([FromBody]JObject value)
        {
            _context.Projects.Add(value.ToObject<Project>());
            _context.SaveChanges();
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody]JObject value)
        {
            Project posted = value.ToObject<Project>();
            posted.id = id; // Ensure an id is attached
            _context.Projects.Update(posted);
            _context.SaveChanges();

            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _context.Projects.Remove(_context.Projects.FirstOrDefault(o => o.id == id));
            _context.SaveChanges();
        }


    }
}
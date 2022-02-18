using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Data.Models;
using Backend;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("app/Plan")]
    public class PlanController : ControllerBase
    {
        private DataContext db;

        public PlanController(DataContext context)
        {
            db = context;
        }

        [HttpPost("GetAllPlans/{id}")]
        public Task<List<User>> GetPersonalPlans(int id)
        {
            return db.User.Where(u => u.Id == id).Include("PersonalPlans").ToListAsync();
        }
    }
}
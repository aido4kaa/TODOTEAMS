using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Data.Models;
using Backend;
using System.Linq;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("app/User")]
    public class UserController : ControllerBase
    {
        private DataContext db;

        public UserController(DataContext context)
        {
            db = context;
        }


        [HttpPost("registration")]
        public async Task<ActionResult<User>> AddNewUser(User body)
        {
            var _user = db.User.FirstOrDefault(u => u.Login == body.Login);
            if (_user == null)
            {
                var newUser = new User { Login = body.Login, Password = body.Password, Name = body.Name };
                await db.User.AddAsync(newUser);
                await db.SaveChangesAsync();
                return Ok(newUser);
            }
            return BadRequest("ƒанный пользователь уже зарегистрирован");
        }
    }
}
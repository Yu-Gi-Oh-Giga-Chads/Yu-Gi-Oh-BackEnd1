using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace Yu_Gi_Oh_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostUsersController : Controller
    {
        YuGiOhDbContext _yuGiOhDbContext = new YuGiOhDbContext();
        [HttpPost("api/addnewuser")]
        public IActionResult postNewUser([FromBody] User newUser)
        {
            _yuGiOhDbContext.Users.Add(newUser);
            _yuGiOhDbContext.SaveChangesAsync();
            return CreatedAtAction("Added new user", new User { Id = newUser.Id });
        }
    }
}

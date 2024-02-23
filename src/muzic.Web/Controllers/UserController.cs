using Microsoft.AspNetCore.Mvc;
using muzic.Domain;

namespace muzic.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> staticUsers = new List<User>();

        //private readonly ILogger<WeatherForecastController> _logger;

       /* public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }
        */
        [HttpGet]
        public ICollection<User> GetUsers()
        {
            return staticUsers;
        }

        [HttpPost(Name = "PostUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            staticUsers.Add(user);
            return CreatedAtAction(nameof(GetUsers), user);
        }
    }
}
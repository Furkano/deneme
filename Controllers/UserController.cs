namespace bdeneme.Controllers
{
    using System.Threading.Tasks;
    using bdeneme.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("name")]
        public async Task<IActionResult> Get(string name)
        {
            var userService = new UserService();
            var gettingname = await userService.GetTaskAsync(name);
            return Ok(gettingname);
        }
    }
}
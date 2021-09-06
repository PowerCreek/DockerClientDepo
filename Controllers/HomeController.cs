using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DockerClientDepo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("trigger")]
        public async Task<IActionResult> Trigger([FromServices] ProxyData proxy)
        {
            proxy.CurrentHost = "https://localhost:5005";
            await Task.Delay(3000);
            proxy.CurrentHost = "https://localhost:5003";
            return Ok("some stuff");
        }
    }
}
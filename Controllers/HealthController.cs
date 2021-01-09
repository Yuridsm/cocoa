using cocoa.Interfaces;
using cocoa.MappingObject;
using cocoa.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace cocoa.Controllers
{
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            var r = HealthProvider.GetSettings();
            var serializerSettings = new JsonSerializerSettings { Formatting = Formatting.Indented };
            return Ok(r);
        }
    }
}

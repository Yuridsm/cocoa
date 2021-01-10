using cocoa.Interfaces;
using cocoa.MappingObject;
using cocoa.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text.Json;

namespace cocoa.Controllers
{
    [Route("[controller]")]
    public class HealthController : ControllerBase
    {
        public AppSettings _appSettings { get; }
        public HealthController(IOptions<AppSettings> appSettings)
        {
            this._appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var r = HealthProvider.GetSettings(this);
            return Ok(r);
        }
    }
}

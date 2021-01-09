using cocoa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using cocoa.Interfaces;

namespace cocoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        public static int Count { get; set; }
        private readonly IDateTime _datetime;

        public readonly IRenderSingleton Singleton0;
        public readonly IRenderSingleton Singleton1;

        public readonly IRenderScoped Scope0;
        public readonly IRenderScoped Scope1;

        public readonly IRenderTransient Transient0;
        public readonly IRenderTransient Transient1;

        public HomeController(
            IRenderScoped scope0,
            IRenderScoped scope1,
            IRenderSingleton singleton0,
            IRenderSingleton singleton1,
            IRenderTransient transient0,
            IRenderTransient transient1,
            IDateTime datetime
        )
        {
            Scope0 = scope0;
            Scope1 = scope1;
            Singleton0 = singleton0;
            Singleton1 = singleton1;
            Transient0 = transient0;
            Transient1 = transient1;
            _datetime = datetime;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_datetime.Now);
        }

    }
}

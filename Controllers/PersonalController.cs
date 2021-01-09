﻿using cocoa.Interfaces;
using cocoa.Services;
using cocoa.Providers;
using Microsoft.AspNetCore.Mvc;

namespace cocoa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonalController : ControllerBase
    {
        private readonly IPersonalInfo _personalInfo;
        public PersonalController(IPersonalInfo personalInfo)
        {
            _personalInfo = personalInfo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            PersonalProvider provider = new PersonalProvider(_personalInfo);
            return Ok(_personalInfo.age);
        }
    }
}

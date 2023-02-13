using fanex.wasa.fps.webservice;
using Fanex.WASA.FPS.DI.Service;
using Fanex.WASA.FPS.DI.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/di")]
    public class DIController : ControllerBase
    {
        private IOffsetService _offsetService;

        public DIController(IOffsetService offsetService)
        {
            _offsetService = offsetService;
        }

        [HttpPost("insert")]
        public void InsertDI([FromBody] DeviceDetection data)
        {
            var a = "Hello world!";
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

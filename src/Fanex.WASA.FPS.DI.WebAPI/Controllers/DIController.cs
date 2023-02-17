using Fanex.Data.Repository;
using Fanex.Logging;
using Fanex.WASA.FPS.DI.Model;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Net.WebSockets;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/di")]
    public class DIController : ControllerBase
    {
        private IDeviceIdentityService _deviceIdentityService;
        private readonly ILogger _logger;

        public DIController(IDeviceIdentityService deviceIdentityService, ILogger logger)
        {
            _deviceIdentityService = deviceIdentityService;
            _logger = logger;
        }

        [HttpPost("insert")]
        public void InsertDI([FromBody] string data)
        {
            // var json = JsonConvert.SerializeObject(data);
            _logger.Info("InsertDI" +
                        "\r\nData: " + data);

            try
            {
                if (data != null)
                {
                    var model = JsonConvert.DeserializeObject<DeviceDetectionEntity>(data);
                    _deviceIdentityService.InsertDeviceIdentity(model);
                }
            }
            catch(Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }

        [HttpPost("insert-details")]
        public void InsertDIDetails([FromBody] DeviceDetectionDetailsEntity data)
        {
            if (data != null)
            {
                _deviceIdentityService.InsertDeviceIdentityDetails(data);
            }
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

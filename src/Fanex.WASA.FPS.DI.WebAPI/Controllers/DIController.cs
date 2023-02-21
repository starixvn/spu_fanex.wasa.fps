using Fanex.Logging;
using Fanex.WASA.FPS.DI.Model.Entity;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<DeviceDetectionEntity>(data);
                if (model != null)
                {
                    _deviceIdentityService.InsertDeviceIdentity(model);
                }
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

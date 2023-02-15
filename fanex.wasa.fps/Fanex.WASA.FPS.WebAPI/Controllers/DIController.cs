using Fanex.WASA.FPS.DI.Model;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/di")]
    public class DIController : ControllerBase
    {
        private IDeviceIdentityService _deviceIdentityService;

        public DIController(IDeviceIdentityService deviceIdentityService)
        {
            _deviceIdentityService = deviceIdentityService;
        }

        [HttpPost("insert")]
        public void InsertDI([FromBody] DeviceDetectionEntity data)
        {
            try
            {
                if (data != null)
                {
                    _deviceIdentityService.InsertDeviceIdentity(data);
                }
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }

        [HttpPost("insert-details")]
        public void InsertDIDetails([FromBody] DeviceDetectionDetailsEntity data)
        {
            try
            {
                if (data != null)
                {
                    _deviceIdentityService.InsertDeviceIdentityDetails(data);
                }
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

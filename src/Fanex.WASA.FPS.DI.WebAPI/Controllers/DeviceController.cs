using Fanex.Logging;
using Fanex.WASA.FPS.Device.Model.Entity;
using Fanex.WASA.FPS.Device.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/device")]
    public class DeviceController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IDeviceService _deviceService;

        public DeviceController(ILogger logger, IDeviceService deviceService)
        {
            _logger = logger;
            _deviceService = deviceService;
        }

        [HttpPost("insert-device")]
        public void InsertDevice([FromBody] string data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data))
                {
                    var model = JsonConvert.DeserializeObject<InsNewDeviceEntity>(data);
                    if (model != null)
                    {
                        _deviceService.InsertNewDevice(model);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }

        [HttpPost("update-device")]
        public void UpdateDevice([FromBody] string data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data))
                {
                    var model = JsonConvert.DeserializeObject<UpdDeviceEntity>(data);
                    if (model != null)
                    {
                        _deviceService.UpdDevice(model);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

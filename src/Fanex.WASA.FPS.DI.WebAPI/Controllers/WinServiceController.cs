using Fanex.Logging;
using Fanex.WASA.FPS.DI.Model;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/win-service")]
    public class WinServiceController : ControllerBase
    {
        private IWinSiteService _winSiteService;
        private readonly ILogger _logger;

        public WinServiceController(IWinSiteService winSiteService, ILogger logger)
        {
            _winSiteService = winSiteService;
            _logger = logger;
        }

        [HttpPost("sub-account-insert")]
        public void SubAccountInsert([FromBody] string data)
        {
            try
            {
                if (data != null)
                {
                    var model = JsonConvert.DeserializeObject<InsAccountDetailEntity>(data);
                    if (model != null)
                    {
                        _winSiteService.InsertSubAccount(model);
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex.Message);
            }
        }
    }
}

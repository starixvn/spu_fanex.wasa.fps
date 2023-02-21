using Fanex.Logging;
using Fanex.WASA.FPS.DI.Model.Entity;
using Fanex.WASA.FPS.DI.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Security.Cryptography;
using System.Text;

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

        [HttpGet("encryptPassword/{pw}")]
        public void EncryptPassword(string pw)
        {
            var encryptedData = Fanex.Data.Cryptography.EncryptPassword(pw);
        }

        [HttpPost("sub-account-insert")]
        public void SubAccountInsert([FromBody] string data)
        {
            try
            {
                if (!string.IsNullOrEmpty(data))
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

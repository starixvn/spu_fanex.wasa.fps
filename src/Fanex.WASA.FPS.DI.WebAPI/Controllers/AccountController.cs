using Fanex.Logging;
using Fanex.WASA.FPS.Account.Model.Entity;
using Fanex.WASA.FPS.Account.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IAccountService _accountService;

        public AccountController(ILogger logger, IAccountService accountService)
        {
            _logger = logger;
            _accountService = accountService;
        }

        [HttpPost("sub-account-insert")]
        public void SubAccountInsert([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<InsAccountDetailEntity>(data);
                if (model != null)
                {
                    _accountService.InsertSubAccount(model);
                }
            }
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

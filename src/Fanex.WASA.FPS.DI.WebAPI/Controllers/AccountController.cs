using Fanex.WASA.FPS.Account.Model.DTO;
using Fanex.WASA.FPS.Account.Model.Entity;
using Fanex.WASA.FPS.Account.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("get-account-by-username/{username}/{type}")]
        public ActionResult<AccountGetByUserNameDTO> GetAccountByUserName(string username, int type)
        {
            var result = _accountService.GetSubAccountByUsername(username, type);
            return Ok(result);
        }

        [HttpPost("insert-sub-account")]
        public void InsertSubAccount([FromBody] string data)
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

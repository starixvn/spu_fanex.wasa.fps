using Microsoft.AspNetCore.Mvc;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet("EncryptPass")]
        public string EncryptPass(string rawPass)
        {
            return Fanex.Data.Cryptography.EncryptPassword(rawPass);                        
        }

        [HttpGet("DecryptPass")]
        public string DecryptPass(string encryptedPass)
        {
            return Fanex.Data.Cryptography.DecryptPassword(encryptedPass);
        }
    }
}

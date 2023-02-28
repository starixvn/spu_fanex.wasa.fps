using Fanex.WASA.FPS.Subcriber.Model.DTO;
using Fanex.WASA.FPS.Subcriber.Service;
using Microsoft.AspNetCore.Mvc;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/subscriber")]
    public class SubscriberController : ControllerBase
    {
        private readonly ISubcriberService _subcriberService;

        public SubscriberController(ISubcriberService subcriberService)
        {
            _subcriberService = subcriberService;
        }

        [HttpGet("get-subscriber/{key}")]
        public ActionResult<SubscriberGetByKeyDTO> GetSubscriberByKey(string key)
        {
            var result = _subcriberService.GetSubscriberByKey(key);
            return result;
        }

    }
}

using Fanex.Logging;
using Fanex.WASA.FPS.Association.Model.Entity;
using Fanex.WASA.FPS.Association.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/association")]
    public class AssociationController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IAssociationService _associationService;

        public AssociationController(ILogger logger, IAssociationService associationService)
        {
            _logger = logger;
            _associationService = associationService;
        }

        [HttpPost("insert-sub-association")]
        public void InsertSubAssociation([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<InsNewAssociationEntity>(data);
                if (model != null)
                {
                    _associationService.InsertSubAssociation(model);
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

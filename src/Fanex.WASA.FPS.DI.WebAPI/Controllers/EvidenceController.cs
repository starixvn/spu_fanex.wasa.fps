using Fanex.Data.Repository;
using Fanex.WASA.FPS.Evidence.Model.Entity;
using Fanex.WASA.FPS.Evidence.Service;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/evidence")]
    public class EvidenceController
    {
        private readonly IEvidenceService _evidenceService;

        public EvidenceController(IEvidenceService evidenceService)
        {
            _evidenceService = evidenceService;
        }

        [HttpPost("insert-sub-evidence")]
        public void InsertSubEvidence([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<InsertSubEvidenceEntity>(data);

                
                if (model != null)
                {
                    _evidenceService.InsertEvidenceSub(model);
                }
            }
        }

        [HttpPost("place-evidence-on-devices")]
        public void PlaceEvidenceOnDevices([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<PlaceEvidenceOnDevicesEntity>(data);

                
                if (model != null)
                {
                    _evidenceService.PlaceEvidenceOnDevices(model);
                }
            }
        }

        [HttpPost("place-evidence-on-accounts")]
        public void PlaceEvidenceOnAccounts([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                var model = JsonConvert.DeserializeObject<PlaceEvidenceOnAccountsEntity>(data);

                
                if (model != null)
                {
                    _evidenceService.PlaceEvidenceOnAccounts(model);
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

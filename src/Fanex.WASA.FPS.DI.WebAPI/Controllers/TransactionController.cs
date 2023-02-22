using Fanex.WASA.FPS.Transaction.Service;
using Microsoft.AspNetCore.Mvc;

namespace Fanex.WASA.FPS.DI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("insert-sub-transaction-by-batch")]
        public void InsertSubTransactionByBatch([FromBody] string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                _transactionService.InsertSubTransactionByBatch(data);
            }
        }

        [HttpGet("hc")]
        public void HealthCheck()
        {
            // Method intentionally left empty.            
        }
    }
}

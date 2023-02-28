using Fanex.WASA.FPS.Account.Model.Entity;
using Fanex.WASA.FPS.Evidence.Model.Entity;
using System.Collections.Generic;

namespace Fanex.WASA.FPS.Account.Model.DTO
{
    public class AccountGetByUserNameDTO
    {
        public IEnumerable<AccountEntity>? AccountEntityList { get; set; }

        public IEnumerable<EvidenceEntity>? EvidenceList { get; set; }
    }
}

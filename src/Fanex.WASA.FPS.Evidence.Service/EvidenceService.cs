using Fanex.WASA.FPS.Evidence.DataAccess;
using Fanex.WASA.FPS.Evidence.Model.Entity;

namespace Fanex.WASA.FPS.Evidence.Service
{
    public interface IEvidenceService
    {
        void InsertEvidenceSub(InsertSubEvidenceEntity entity);

        void PlaceEvidenceOnDevices(PlaceEvidenceOnDevicesEntity entity);

        void PlaceEvidenceOnAccounts(PlaceEvidenceOnAccountsEntity entity);
    }

    public class EvidenceService : IEvidenceService
    {
        private readonly IEvidenceDataAccess evidenceDataAccess;

        public EvidenceService(IEvidenceDataAccess evidenceDataAccess)
        {
            this.evidenceDataAccess = evidenceDataAccess;
        }

        public void InsertEvidenceSub(InsertSubEvidenceEntity entity)
        {
            evidenceDataAccess.InsertEvidenceSub(entity);
        }

        public void PlaceEvidenceOnDevices(PlaceEvidenceOnDevicesEntity entity)
        {
            evidenceDataAccess.PlaceEvidenceOnDevices(entity);
        }

        public void PlaceEvidenceOnAccounts(PlaceEvidenceOnAccountsEntity entity)
        {
            evidenceDataAccess.PlaceEvidenceOnAccounts(entity);
        }
    }
}

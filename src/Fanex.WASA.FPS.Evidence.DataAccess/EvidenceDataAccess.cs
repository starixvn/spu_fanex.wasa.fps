using Fanex.Data.Repository;
using Fanex.WASA.FPS.Evidence.DataAccess.Criteria;
using Fanex.WASA.FPS.Evidence.Model.Entity;

namespace Fanex.WASA.FPS.Evidence.DataAccess
{
    public interface IEvidenceDataAccess
    {
        void InsertEvidenceSub(InsertSubEvidenceEntity entity);

        void PlaceEvidenceOnDevices(PlaceEvidenceOnDevicesEntity entity);

        void PlaceEvidenceOnAccounts(PlaceEvidenceOnAccountsEntity entity);
    }

    public class EvidenceDataAccess : IEvidenceDataAccess
    {
        private readonly IDynamicRepository repository;

        public EvidenceDataAccess()
        {
            repository = new DynamicRepository();
        }

        public void InsertEvidenceSub(InsertSubEvidenceEntity entity)
        {
            var criteria = new EvidenceSubInsertCriteria
            {
                AffectedDate = entity.AffectedDate,
                EviId = entity.EviId,
                EviSource = entity.EviSource,
                ItemId = entity.ItemId,
                ItemType = entity.ItemType,
                ItemValue = entity.ItemValue,
                LevelId = entity.LevelId,
                SubscriberId = entity.SubscriberId
            };

            repository.Execute(criteria);
        }

        public void PlaceEvidenceOnDevices(PlaceEvidenceOnDevicesEntity entity)
        {
            var criteria = new PlaceEvidenceOnDevicesCriteria
            {
                AffectedDate = entity.AffectedDate,
                DeviceIds = entity.DeviceIds,
                DeviceNos = entity.DeviceNos,
                EviId = entity.EviId,
                EviSource = entity.EviSource,
                IsRetract = entity.IsRetract,
                ItemType = entity.ItemType,
                LevelId = entity.LevelId,
                SubscriberId = entity.SubscriberId
            };

            repository.Execute(criteria);
        }

        public void PlaceEvidenceOnAccounts(PlaceEvidenceOnAccountsEntity entity)
        {
            var criteria = new PlaceEvidenceOnAccountsCriteria
            {
                AffectedDate = entity.AffectedDate,
                AccountIds = entity.AccountIds,
                AccountNames = entity.AccountNames,
                EviId = entity.EviId,
                EviSource = entity.EviSource,
                IsRetract = entity.IsRetract,
                ItemType = entity.ItemType,
                LevelId = entity.LevelId,
                SubscriberId = entity.SubscriberId
            };

            repository.Execute(criteria);
        }
    }
}

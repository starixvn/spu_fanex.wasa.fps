using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fanex.WASA.FPS.DI.Service
{
    public interface IOffsetService
    {
        IEnumerable<OffsetEntity> GetOffset();
    }

    public class OffsetService : IOffsetService
    {
        private readonly IOffsetDataAccess offsetDataAccess;

        public OffsetService(IOffsetDataAccess offsetDataAccess)
        {
            this.offsetDataAccess = offsetDataAccess;
        }

        public IEnumerable<OffsetEntity> GetOffset()
        {
            return offsetDataAccess.GetOffset();
        }
    }
}

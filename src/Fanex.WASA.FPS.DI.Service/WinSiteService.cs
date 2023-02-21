using Fanex.WASA.FPS.DI.DataAccess;
using Fanex.WASA.FPS.DI.Model.Entity;

namespace Fanex.WASA.FPS.DI.Service
{
    public interface IWinSiteService
    {
        void InsertSubAccount(InsAccountDetailEntity entity);
    }

    public class WinSiteService : IWinSiteService
    {
        private readonly IWinSiteDataAccess winSiteDataAccess;

        public WinSiteService(IWinSiteDataAccess winSiteDataAccess)
        {
            this.winSiteDataAccess = winSiteDataAccess;
        }

        public void InsertSubAccount(InsAccountDetailEntity entity)
        {
            winSiteDataAccess.InsertSubAccount(entity);
        }
    }
}

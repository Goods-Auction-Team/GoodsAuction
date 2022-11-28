using System.Data.Common;

namespace GoodsAuction.Control
{ 

    public class StartupController : Controller
    {
        public void initiate()
        {
            DBConnect.initiateDB();
        }
    }
}
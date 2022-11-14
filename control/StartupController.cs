using System.Data.Common;
using system;
namespace Control;

public class StartupController : Control 
{
    public void initiate();
    {
        DBConnect.initiateDB();
    }
}
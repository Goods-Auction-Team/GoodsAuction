using System.Data.Common;
using system;
package Control;

public class StartupController : Control 
{
    public void initiate();
    {
        DBConnect.initiateDB();
    }
}
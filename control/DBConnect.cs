using System;
using GoodsAuction.Entity;

namespace GoodsAuction.Control
{
    public class DBConeect : Controller
{
    private Account user;
    private Item itemID;
    private ItemList item;

    public void initDB();
    {

    }

    public DBConnect(username)
    {
        this username = username;
    }

    public Account getUser()
    {
        return username;
    }
    
    public void saveLogout(username)
    {
        this username = username;
    }
    
    public Item getItem(itemID)
    {
        //This item ID returns the item
    }

    public ItemList modifyItem(itemID, newBid, username)
    {
        //This is the placebid where it updates the item after bid and 
        //returns ItemList
    }

    public ItemList saveItem(Item)
    {
        //This is the addItem where the data is saved
    }

}
}
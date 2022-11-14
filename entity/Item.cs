using System;
using entity.Account;

public class item 
{
    private int itemID;
    private string itemName;
    private string itemDescription;
    private float startingBid;
    private float currentBid;
    private DateTime timeRemaining; //not sure if this is correct
    private string currentLeader;
    private Account username;

    public int getItemID()
    {
        return itemID;
    }
    public void setItemID(int itemID)
    {
        this itemID = itemID;
    }
    public string getItemName()
    {
        return itemName;
    }
    public void setItemName(string itemName)
    {
        this itemName = itemName;
    }
    public string getItemDescription()
    {
        return itemDescription;
    }
    public void setItemDescription(string itemDescription)
    {
        this itemDescription = itemDescription;
    }
    public float getStartingBid()
    {
        return startingBid;
    }
    public void setStartingBid(float startingBid)
    {
        this startingBid = startingBid;
    }
    public float getCurrentBid()
    {
        return currentBid;
    }
    public void setCurrentBid(float currentBid)
    {
        this currentBid = currentBid;
    }
    public DateTime getTimeRemaining()
    {
        return timeRemaining; //Not sure if this is correct
    }
    public void setTimeRemaining(DateTime timeRemaining)
    {
        this timeRemaining = timeRemaining;
    }
    public Account string getCurrentLeader();
    {
        return username; //maybe??
    }
    public void setCurrentLeader(string username)
    {
        this username = username;
    }

}
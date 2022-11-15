//not sure where to start here
using System;
using entity.Item;

public class ItemList;
{
    List<Item> itemList = new List<Item>();
    
    public void addItem(Item newItem)
    {
        itemList.Add(newItem);
    }

    public List<List> returnList()
    {
        return ItemList;
    }
}
    


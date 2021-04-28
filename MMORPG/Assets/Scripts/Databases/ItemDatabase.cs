using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase
{
    public List<Item> items;

    public ItemDatabase(List<ItemObject> itemObjects)
    {
        items = new List<Item>();
        
        foreach(ItemObject item in itemObjects)
        {
            items.Add(new Item(item));
        }
    }

    
}



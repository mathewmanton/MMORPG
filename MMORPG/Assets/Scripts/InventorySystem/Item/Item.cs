using System;
using UnityEngine;

public enum ItemType { Container, Consumable, Weapon, Armor};

public class Item
{

    public int id;
    public string name;
    public string description;
    public ItemType ItemType;
    public int maxQuantity;

    //First int = Gold, Second = Silver, Third = Copper
    public int sellPrice; 

    public Item()
    {

    }

    public Item(ItemObject item)
    {
        id = item.id;
        name = item.name;
        description = item.description;
        sellPrice = item.sellPrice;
        maxQuantity = item.maxQuantity;
    }
}

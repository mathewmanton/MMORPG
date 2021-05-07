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

    //
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

    public Item(int id, string name, string description, ItemType type, int maxQuantity, int sellPrice)
    {
        this.id = id;
        this.name = name;
        this.description = description;
        ItemType = type;
        this.maxQuantity = maxQuantity;
        this.sellPrice = sellPrice;
    }
}

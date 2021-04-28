
using System;
using UnityEngine;

public class ItemObject : ScriptableObject
{
    public int id;
    public string name;

    [TextArea(3,10)]
    public string description;

    public ItemType ItemType;

    [Tooltip("Max quantity per stack")]
    public int maxQuantity;

    [Tooltip("This represents the money in Copper Pieces")]
    public int sellPrice;

}


using System;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        wheat,
        wheat_seeds,
    }

    public ItemType itemType;
    public int amount;
    public bool stackable;
}

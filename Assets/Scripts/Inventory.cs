using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    public static int size = 12;
    public Item[] itemArray;

    public static void Main()
    {
        Item[] itemArray = new Item[size];
    }

    public Inventory()
    {
        itemArray = new Item[size];
    }

    public void AddItem(Item item)
    {
        for (int i = 0; i < itemArray.Length; i++)
        {
            if (itemArray[i] == null)
            {
                itemArray[i] = item;
            }
            if (itemArray[i] != null && itemArray[i].itemType == item.itemType)
            {
                itemArray[i].amount++;
            }
        }
    }

    public Array GetArray()
    {
        return itemArray;
    }

    public int GetSize()
    {
        return size;
    }
}

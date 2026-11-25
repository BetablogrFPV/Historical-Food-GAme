using System;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        wheat,
        wheat_seeds,
        placeholder,
    }

    public ItemType itemType;
    public int amount;
    public bool stackable;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.wheat:       return ItemAssets.Instance.wheatSprite;
            case ItemType.wheat_seeds: return ItemAssets.Instance.wheatSeedSprite;
            case ItemType.placeholder: return null;
        }
    }
}

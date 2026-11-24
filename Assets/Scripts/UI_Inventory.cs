using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public CanvasRenderer slot_1;
    public CanvasRenderer slot_2;
    public CanvasRenderer slot_3;
    public CanvasRenderer slot_4;
    public CanvasRenderer slot_5;
    public CanvasRenderer slot_6;
    public CanvasRenderer slot_7;
    public CanvasRenderer slot_8;
    public CanvasRenderer slot_9;
    public CanvasRenderer slot_10;
    public CanvasRenderer slot_11;
    public CanvasRenderer slot_12;

    public CanvasRenderer hotbar_1;
    public CanvasRenderer hotbar_2;
    public CanvasRenderer hotbar_3;
    public CanvasRenderer hotbar_4;
    
    void Awake()
    {
        
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void RefreshInventoryItems()
    {

    }
}

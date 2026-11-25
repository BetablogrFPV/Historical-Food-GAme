using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UI_Inventory : MonoBehaviour
{
    private Inventory inventory;
    public UnityEngine.UI.Image slot_1 = GameObject.FindGameObjectWithTag("slot1").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_2 = GameObject.FindGameObjectWithTag("slot2").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_3 = GameObject.FindGameObjectWithTag("slot3").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_4 = GameObject.FindGameObjectWithTag("slot4").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_5 = GameObject.FindGameObjectWithTag("slot5").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_6 = GameObject.FindGameObjectWithTag("slot6").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_7 = GameObject.FindGameObjectWithTag("slot7").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_8 = GameObject.FindGameObjectWithTag("slot8").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_9 = GameObject.FindGameObjectWithTag("slot9").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_10 = GameObject.FindGameObjectWithTag("slot10").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_11 = GameObject.FindGameObjectWithTag("slot11").GetComponent<UnityEngine.UI.Image>();
    public UnityEngine.UI.Image slot_12 = GameObject.FindGameObjectWithTag("slot12").GetComponent<UnityEngine.UI.Image>();

    public CanvasRenderer hotbar_1;
    public CanvasRenderer hotbar_2;
    public CanvasRenderer hotbar_3;
    public CanvasRenderer hotbar_4;
    public int size;
    public Item[] inv;

    void Awake()
    {
        size = Inventory.size;
        Array.Copy(inventory.GetArray(), 0, inv, 0, inventory.GetArray().Length);
    }

    void Update()
    {
        RefreshInventoryItems();
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
    }

    public void RefreshInventoryItems()
    {
        if (inv != null)
        {
            Array.Copy(inventory.GetArray(), 0, inv, 0, inventory.GetArray().Length);
            UnityEngine.UI.Image[] slots = { slot_1, slot_2, slot_3, slot_4, slot_5, slot_6, slot_7, slot_8, slot_9, slot_10, slot_11, slot_12 };
            for (int i = 0; i < inventory.GetSize(); i++)
            {
                if (inv[i] != null)
                {
                    slots[i].sprite = inv[i].GetSprite();
                }
            }
        }
    }
}

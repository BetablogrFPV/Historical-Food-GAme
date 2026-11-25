using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class CharScript : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private UI_Inventory ui_Inventory;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Awake()
    {
        inventory = new Inventory();
        ui_Inventory.SetInventory(inventory);
        Debug.Log("Inv instantiated!");
        inventory.AddItem(new Item { itemType = Item.ItemType.wheat, amount = 1, stackable = true });
        Debug.Log("Item added!");
    }
}

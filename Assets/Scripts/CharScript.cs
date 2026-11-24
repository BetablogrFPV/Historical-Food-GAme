using UnityEngine;

public class CharScript : MonoBehaviour
{
    private Inventory inventory;
    
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
    }
}

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class CharMoveScript : MonoBehaviour
{
    public float movementLength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        // Checking if a keyboard is detected
        if (Keyboard.current == null)
            return;
        
        // Movement to the left
        if(Keyboard.current.aKey.wasPressedThisFrame || Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
           transform.position = transform.position + (Vector3.left * movementLength);
        }

        // Movement to the right
        if (Keyboard.current.dKey.wasPressedThisFrame || Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            transform.position = transform.position + (Vector3.right * movementLength);
        }

        // Movement up
        if (Keyboard.current.wKey.wasPressedThisFrame || Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            transform.position = transform.position + (Vector3.up * movementLength);
        }

        // Movement down
        if (Keyboard.current.sKey.wasPressedThisFrame || Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            transform.position = transform.position + (Vector3.down * movementLength);
        }
    }

}

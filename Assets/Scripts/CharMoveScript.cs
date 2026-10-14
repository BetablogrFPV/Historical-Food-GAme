using UnityEngine;
using UnityEngine.InputSystem;


public class CharMoveScript : MonoBehaviour
{
    public float movementLength;
    public Rigidbody2D rb;
    private Vector2 _moveDirection;
    public InputActionReference move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moveDirection = move.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(x:_moveDirection.x * movementLength, y:_moveDirection.y * movementLength);
    }
}

using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class FarmScript : MonoBehaviour
{
    Vector3 mousePosition;
    RaycastHit2D raycastHit2D;
    public Collider2D collider;
    public GameObject player;
    Transform clickObject;
    public Sprite highlight;
    public Canvas interactionMenu;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkAvailibility();
        if (collider.IsTouching(player.GetComponent<Collider2D>()))
        {
            Debug.Log("Touched!");
        }
    }

    private void checkAvailibility()
    {
        mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (clickObject && collider.IsTouching(player.GetComponent<Collider2D>()))
            {
                interactionMenu.gameObject.SetActive(true);
            }
        }

        if (collider.IsTouching(player.GetComponent<Collider2D>()))
        {
            clickObject.GetComponent<SpriteRenderer>().sprite = highlight;
        }
    }
}

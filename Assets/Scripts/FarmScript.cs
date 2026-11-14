using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FarmScript : MonoBehaviour, IPointerClickHandler
{
    public Collider2D collider;
    public GameObject player;
    public Sprite highlight;
    public RectTransform interactionMenu;
    public Canvas canvas;
    public float xOffset;
    public float yOffset;
    public float multiplier;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (collider == null || player == null)
        {
            return;
        }

        var playerCollider = player.GetComponent<CircleCollider2D>();

        if (playerCollider != null && collider.IsTouching(playerCollider))
        {
            Debug.Log("Collider: " + collider.transform.position.x + ", " + collider.transform.position.y);
            interactionMenu.position = new Vector2(
                collider.transform.position.x + xOffset,
                collider.transform.position.y + (yOffset * multiplier));
            canvas.gameObject.SetActive(true);
            Debug.Log("Interaction-Menu: " + interactionMenu.position);
        }
    }
}

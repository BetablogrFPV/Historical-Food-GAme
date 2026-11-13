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
        if (collider.IsTouching(player.GetComponent<CircleCollider2D>()))
        {
            interactionMenu.position = new Vector2(x:collider.transform.position.x + xOffset, y:collider.transform.position.y + yOffset);
            canvas.gameObject.SetActive(true);
            Debug.Log(interactionMenu.position);
        }
    }
}

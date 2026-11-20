using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class FarmScript : MonoBehaviour, IPointerClickHandler
{
    public Collider2D collider;
    public GameObject player;
    public Sprite highlight;
    public GameObject logicManager;

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

    }
}

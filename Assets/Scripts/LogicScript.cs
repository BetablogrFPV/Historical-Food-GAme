using UnityEngine;
using UnityEngine.EventSystems;

public class LogicScript : MonoBehaviour
{
    public GameObject player;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkRange()
    {
        var playerCollider = player.GetComponent<CircleCollider2D>();

        Vector3 pos = this.transform.position;
        float dist = float.PositiveInfinity;
        ChaseableEntity targ = null;
        foreach(var obj in ChaseableEntity.Entities)
        {
            var d = (pos - obj.transform.position).sqrMagnitude;
            if(d < dist)
            {
                targ = obj;
                dist = d;
            }
        }
        if (playerCollider.IsTouching(obj.GetComponent<Collider2D>))
        {
            Debug.Log("Touched");
        }
    }
}

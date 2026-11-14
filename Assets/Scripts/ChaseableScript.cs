//The methodes of this script were written by the user "lordofduct" in the year 2019. Link to the
//post is "https://discussions.unity.com/t/find-nearest-object-with-tag/750830/2"

// Add this script to every object in the game that the player can interact with so it can be detected and highlighted when in range
using UnityEngine;
using System.HashSet;

public class ChaseableEntity : MonoBehaviour
{

    public static readonly HashSet<ChaseableEntity> Entities = new HashSet<ChaseableEntity>();
  
    void Awake()
    {
        Entities.Add(this);
    }
  
    void OnDestroy()
    {
        Entities.Remove(this);
    }

}

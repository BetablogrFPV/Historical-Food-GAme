using UnityEngine;
using static UnityEngine.Time;


public class CropScript : MonoBehaviour
{
    public ScriptableCrop scriptable;
    public SpriteRenderer renderer;
    public string cropName;
    public int growingTimer;
    public int growthStage;
    public float timer = 0;
    public bool mature;
    [SerializeField]
    public Sprite image1;
    [SerializeField]
    public Sprite image2;
    [SerializeField]
    public Sprite image3;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cropName = scriptable.cropName;
        growingTimer = scriptable.growingTimer;
        growthStage = scriptable.growthStage;
        image1 = scriptable.image1;
        image2 = scriptable.image2;
        image3 = scriptable.image3;
        renderer.sprite = image1;
    }

    // Calls every Frame
    void Update()
    {
        //Debug.Log("Update!");
        if (!mature)
        {
            //Debug.Log(Time.deltaTime);
            timer += Time.deltaTime;
            //Debug.Log("Timer: " + timer);
        }
        grow();
        //Debug.Log("Stage: " + growthStage);
    }

    public void grow()
    {
        if (!mature)
        {
            if(timer >= growingTimer)
            {
                growthStage++;
                timer = 0;
                if (growthStage == 2)
                {
                    renderer.sprite = image2;
                }
                if (growthStage == 3)
                {
                    renderer.sprite = image3;
                    mature = true;
                }
            }
        }
    }
}

using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableCrop", menuName = "Scriptable Objects/ScriptableCrop")]
public class ScriptableCrop : ScriptableObject
{
    public string cropName;
    public int growingTimer;
    public int growthStage = 1;
    [SerializeField]
    public Sprite image1;
    [SerializeField]
    public Sprite image2;
    [SerializeField]
    public Sprite image3;

    public void grow(int pGrowingTimer, int pGrowthStage)
    {
        int timer = 0;
        if (pGrowthStage != 3)
        {
            if (timer < pGrowingTimer)
            {
                timer++;
            }
            if(timer == pGrowingTimer)
            {
                pGrowthStage++;
            }
        }
    }
}

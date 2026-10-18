using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableCrop", menuName = "Scriptable Objects/ScriptableCrop")]
public class ScriptableCrop : ScriptableObject
{
    public string name;
    public int growingTimer;
    public int growthStage = 1;
    public SpriteRenderer spriteRenderer;
    public Image image1;
    public Image image2;
    public Image image3;

    protected void FixedUpdate()
    {
        grow();
    }

    public void grow()
    {
        while (growthStage != 3)
        {
            for (int i = 0; i <= growingTimer; i++)
            {
                if (i == growingTimer)
                {
                    growthStage++;
                }
            }
        }
    }
}

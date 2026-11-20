using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

public class RandomListScript : MonoBehaviour
{
    public object GetRandomElements(ArrayList inputList, int count)
    {
        for (int i = 0; i < inputList.Count; i++)
        {
            float rndm = Random.Range(0, inputList.Count);
            inputList[i] = inputList[(int)rndm];
        }
        return inputList[count];
    }
}
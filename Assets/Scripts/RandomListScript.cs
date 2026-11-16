using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomListScript : MonoBehaviour
{
    public List<T> GetRandomElements<T>(List<T> inputList, int count)
    {
        List<T> listClone = new List<T>(inputList);
        Shuffle(listClone);
        return listClone.GetRange(0,count);
    }

    void Shuffle<T>(List<T> inputList)
    {
        for (int i = 0; i < inputList.Count-1; i++)
        {
            T tmp = inputList[i];
            int rand = Random.Range(i, inputList.Count);
            inputList[i] = inputList[rand];
            inputList[rand] = tmp;
        }
    }
}

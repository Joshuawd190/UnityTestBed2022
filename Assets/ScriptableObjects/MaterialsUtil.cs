using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class MaterialsUtil : ScriptableObject
{
    public ItemData[] MaterialsList;

    public ItemData GetMat(string x)
    {
        foreach (var item in MaterialsList)
        {
            if (item.MaterialType == x)
            {
                return item;
            }
        }
        return null;
    }


    public ItemData GetRandMat()
    {

        return MaterialsList[Mathf.RoundToInt(Random.Range(0, (MaterialsList.Length)))];
    }




}

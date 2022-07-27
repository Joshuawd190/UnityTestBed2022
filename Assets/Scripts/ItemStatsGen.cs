using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStatsGen : MonoBehaviour
{

    public MaterialsUtil BodyMaterial;

    public ItemData Stats;
    // Start is called before the first frame update
    void Start()
    {
        Stats = BodyMaterial.GetRandMat();

        Debug.Log("The body material of the ring is: " + Stats.MaterialType +
        " The minimum bonus is: " + Stats.MinStatVal +
        " The maximum bonus is: " + Stats.MaxStatVal);
    }


}

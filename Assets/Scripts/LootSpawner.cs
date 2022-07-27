using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpawner : MonoBehaviour
{

    public GameObject ringPrefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SpawnLoot();

        }




    }

    public void SpawnLoot()
    {
        Instantiate(ringPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject üzüm;
    float randomX;
    float randomZ;
    void Start()
    {
        spawnerControl();

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void spawnerControl()
    {
        for (int i = 0; i <= 30; i++)
        {
            randomX = Random.Range(-4, 4);
            randomZ = Random.Range(0, 4);
            Instantiate(üzüm, new Vector3(randomX, 0, randomZ), Quaternion.identity);

        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaCode : MonoBehaviour
{
    public GameObject hotDog;
    int ID;
    void Start()
    {
        ID = GetInstanceID();
    }

    // Update is called once per frame
    void Update()
    {
        Physics.gravity = new Vector3(0, -10.0F, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "banana")
        {
            if (ID < collision.gameObject.GetComponent<bananaCode>().ID)
            {
                GameObject O = Instantiate(hotDog, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hotDogCode : MonoBehaviour
{
    public GameObject hamburger;
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
        if (collision.gameObject.tag == "hotDog")
        {
            if (ID < collision.gameObject.GetComponent<hotDogCode>().ID)
            {
                GameObject O = Instantiate(hamburger, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cherryCode : MonoBehaviour
{
    public GameObject banana;
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
        if (collision.gameObject.tag == "cherry")
        {
            if (ID < collision.gameObject.GetComponent<cherryCode>().ID)
            {
                GameObject O = Instantiate(banana, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}

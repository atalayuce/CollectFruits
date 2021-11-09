using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whistle : MonoBehaviour
{
    int ID;
    public GameObject cherry;
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
        if (collision.gameObject.tag == "olive")
        {
            if (ID < collision.gameObject.GetComponent<whistle>().ID)
            {
                Debug.Log($"Sending Message From {gameObject.name} with The Number of {ID}");
                GameObject O = Instantiate(cherry, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hamburgerCode : MonoBehaviour
{
    public GameObject waterMelon;
    public Text gameOver;
    int ID;
    void Start()
    {
        ID = GetInstanceID();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "hamburger")
        {
            if (ID < collision.gameObject.GetComponent<hamburgerCode>().ID)
            {
                GameObject O = Instantiate(waterMelon, transform.position, Quaternion.identity);
                Destroy(collision.gameObject);
                Destroy(gameObject);
                Time.timeScale = 0;
                gameOver.text = "OYUN BİTTİ";
            }

        }
    }
}

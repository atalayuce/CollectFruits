using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour
{
    // Update is called once per frame
    public Vector3 myPos;
    public Transform myPlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }



    public void Update()
    {
        transform.position = myPlay.position + myPos;
    }
}

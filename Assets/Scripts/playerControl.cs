using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    Vector3 newPosition;
    bool isMove = false;
    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();

        transform.position = new Vector3(transform.position.x, 0, transform.position.z);

        Physics.gravity = new Vector3(0, -20.0F, 0);
    }

    void movePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition = hit.point;
                isMove = true;
            }
            //transform.LookAt(newPosition);

       
        }

        if (isMove == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, newPosition, 1 * Time.deltaTime);
            Vector3 relativePos = newPosition - transform.position;
            Quaternion toRotation = Quaternion.LookRotation(relativePos);
            transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, 5 * Time.deltaTime);

        }
        else if (transform.position == newPosition)
        {
            isMove = false;
        }


    }



}

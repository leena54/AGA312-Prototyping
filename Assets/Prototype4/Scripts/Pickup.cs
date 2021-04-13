using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public Transform theDest;
    private float distance;
    public Transform player;
    


    void Start()
    {

    }


    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position);

        if(dist < 1.5)
        {
            print("press space to pickup");
        }


        distance = Vector3.Distance(theDest.position, transform.position);

        if (Input.GetKeyDown("space") && distance < 1.5)
        {

            GetComponent<Rigidbody>().isKinematic = true;
            this.transform.position = theDest.position;
            this.transform.parent = GameObject.Find("Destination").transform;
            
        }

        else if (Input.GetKeyUp("space"))
        {
            this.transform.parent = null;

            GetComponent<Rigidbody>().isKinematic = false;
        }


    }
}

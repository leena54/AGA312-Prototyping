using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotate : MonoBehaviour
{
    float rotSpeed = 40;
    public GameObject shape;
    private Vector3 startPos;
    private Vector3 endPos;
    private float distance = 5.5f;
    private float lerpTime = 5;
    private float currentLerpTime;
    private bool keyHit = false;
    public Camera frontCam;
    public Camera backCam;
    public GameObject loseText;
    


    void Start()
    {
        startPos = shape.transform.position;
        endPos = shape.transform.position + Vector3.forward * distance;
        frontCam.enabled = true;
        backCam.enabled = true;


    }

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        transform.Rotate(Vector3.up, -rotX);
        transform.Rotate(Vector3.right, rotY);
    }


    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            keyHit = true;
            frontCam.enabled = false;
            backCam.enabled = true;
        }

        if (keyHit == true)
        {
            currentLerpTime += Time.deltaTime;
            if(currentLerpTime >= lerpTime)
            {
                currentLerpTime = lerpTime;
            }

            float Perc = currentLerpTime / lerpTime;
            shape.transform.position = Vector3.Lerp(startPos, endPos, Perc);
        }

    }




    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == ("Wall"))
        {
            loseText.SetActive(true);
            keyHit = false;
            //shape.transform.position = new Vector3(0, 0, -1);
        }
    }

}

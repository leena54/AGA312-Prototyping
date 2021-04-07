using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera frontCam;
    public Camera backCam;

    void Start()
    {
        frontCam.enabled = true;
        backCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            frontCam.enabled = !frontCam.enabled;
            backCam.enabled = !backCam.enabled;
        }


    }
}

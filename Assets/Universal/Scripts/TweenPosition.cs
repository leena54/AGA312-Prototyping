using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenPosition : JMC
{
    public float tweenTime = 2f;
    public Ease ease;
    public Camera cam;

    void Start()
    {
        
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TweenPos();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PingPong();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Hit();
        }
    }

    void TweenPos()
    {
        transform.DOMoveX(5, tweenTime).SetLoops(-1).SetEase(ease);
    }

    void PingPong()
    {
        transform.DOMoveX(5, tweenTime).SetEase(ease).OnComplete(() =>
        transform.DOMoveX(5, tweenTime).SetEase(ease).OnComplete(() => 
        PingPong()));

    }

    void Hit()
    {
        transform.DOPunchScale(Vector3.one * 1.5f, tweenTime, 2,0.3f);
        GetComponent<Renderer>().material.DOColor(Color.red, 0.1f).OnComplete(() =>
        GetComponent<Renderer>().material.DOColor(Color.black, tweenTime));
        cam.DOShakeRotation(tweenTime,2,2,2);
        cam.DOShakePosition(tweenTime, 2, 2, 2);
        cam.DOFieldOfView(120, 0.3f).OnComplete(() => cam.DOFieldOfView(60, 0.3f));
    }


}

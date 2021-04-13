using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tables : MonoBehaviour
{
    public GameObject food;
    public GameObject text;
    public GameObject nextText;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == ("Forty five"))
        {
            Destroy(food);
            Destroy(text);
            nextText.SetActive(true);
        }
    }
}

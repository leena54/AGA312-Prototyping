using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tables : MonoBehaviour
{
    public GameObject food;
    public GameObject text;
    public GameObject nextText;

    public Slider hungerBar;
    public float hunger;
    public float maxHunger;

    public int myNumber;

    void Start()
    {
        hunger = maxHunger;
        hungerBar.maxValue = maxHunger;
        hungerBar.value = hunger;
    }


    void Update()
    {
        hunger -= Time.deltaTime;
        hungerBar.value = hunger;
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

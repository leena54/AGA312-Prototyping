using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tables : JMC
{
    public GameObject food;
    public GameObject text;
    //public GameObject nextText;

    public Slider hungerBar;
    public float hunger;
    public float maxHunger;

    public int myNumber;
    public int cash;

    public int score;
    public Text scoreText;

    void Start()
    {
        hunger = maxHunger;
        hungerBar.maxValue = maxHunger;
        hungerBar.value = hunger;

        scoreText.text = "CASH: $" + score;
    }


    void Update()
    {
        hunger -= Time.deltaTime;
        hungerBar.value = hunger;

        if(hunger <= 0 )
        {
            text.SetActive(true);
            
        }
    
    }

    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == ("Food"))
        {
            if (other.GetComponent<Pickup>().myNumber == myNumber)
            {
                Destroy(other.gameObject);
                _NM.ResetTable(this);

                IncreaseScore();

            }



        }



       // if(other.gameObject.tag == ("Forty five"))
       // {
       //   Destroy(food);
       // Destroy(text);
       //nextText.SetActive(true);
       //}
    }

    private void IncreaseScore()
    {
        score+= 10;
        scoreText.text = "Cash: $ " + score;
    }
}

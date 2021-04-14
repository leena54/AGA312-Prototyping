using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{
    public List<int> ingredientNumbers;
    public GameObject nine, five, food;
    public bool touchedNine = false;
    public bool touchedFive = false;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Pickup>())
        {
            ingredientNumbers.Add(other.GetComponent<Pickup>().myNumber);
        }

        /*
        if (other.gameObject.tag == ("Nine"))
        {
            touchedNine = true;
        }

        if (other.gameObject.tag == ("Five"))
        {
            touchedFive = true;
        }

        if(touchedFive && touchedNine)
        {
            Destroy(nine);
            Destroy(five);
            food.transform.position = new Vector3(-2, 2, 16);
        }*/

        if(ingredientNumbers.Count >1)
            food.transform.position = new Vector3(-2, 2, 16);

    }
}

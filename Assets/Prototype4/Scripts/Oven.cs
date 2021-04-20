using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oven : MonoBehaviour
{
    
    public List<int> ingredientNumbers;
    public GameObject food;
    
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

            int ans = ingredientNumbers[0] * ingredientNumbers[1];
            food.GetComponentInChildren<TextMeshPro>().text = ans.ToString();

        }



        if(ingredientNumbers.Count >1)
        {
            Instantiate(food, new Vector3(-2, 2, 16), Quaternion.identity);

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
        }
        */
    }
    

}

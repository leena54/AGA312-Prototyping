using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oven : JMC
{
    
    public List<int> ingredientNumbers;
    public GameObject food;
    
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Pickup>())
        {

            ingredientNumbers.Add(other.GetComponent<Pickup>().myNumber);
            _NM.pickups.Remove(other.gameObject);
            Destroy(other.gameObject);
            

        }

        if(ingredientNumbers.Count >1)
        {
            int ans = ingredientNumbers[0] * ingredientNumbers[1];
            
            GameObject go = Instantiate(food, new Vector3(-17, 2, 9), Quaternion.identity);
            go.GetComponentInChildren<TextMeshPro>().text = ans.ToString();
            go.GetComponent<Pickup>().myNumber = ans;
            ingredientNumbers.Clear();
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

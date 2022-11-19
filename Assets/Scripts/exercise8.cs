using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise8 : MonoBehaviour
{
    public int points;

    private void Start()
    {
        if (points > 100)   //greater than
        {
            Debug.Log("You have more than 100 points");
        }
        else if (points<=100 && points>75)    //greater than or equal and less than
        {
            Debug.Log("You have more than 75 points, but less than or equal to 100");
        }
        else if (points<=75 && points>50)
        {
            Debug.Log("You have more than 50 points, but less than or equal to 75");
        }
        else if (points<=50 && points>25)
        {
            Debug.Log("You have more than 25 points, but less than or equal to 50");
        }
        else   //all numbers less than 25
        {
            Debug.Log("You have less than or equal to 25 points");
        }

    }
}

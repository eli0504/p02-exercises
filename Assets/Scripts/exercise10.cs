using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise10 : MonoBehaviour
{
    public int year;

    private void Start()
    {
        if(year % 4 == 0 && year % 100 == 0)
        {
            Debug.Log("It is a leap year");
        }
        else if(year % 100 == 0 && year % 400 == 0)
        {
            Debug.Log("It is a leap year");
        }
        else
        {
            Debug.Log("Not a leap year");                           /*For a year to be a leap year it must be divisible by 4 and it must not 
                                                                      be divisible by 100, unless it is also divisible by 400
                                                                    */
        }
    }
}

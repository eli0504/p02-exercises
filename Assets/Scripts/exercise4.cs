using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise4 : MonoBehaviour
{
   public float b = 10f;  //base
   public float height = 5f;


    private float result;
    private void Start()
    {
        result = b * height / 2;  //formula to calculate the area of the triangle
        if(result>0)
        {
            Debug.Log(result);
        }
        else  
        {
            Debug.Log("The area cannot be calculated.");   /*
                                                            instead, the number is negative and cannot be calculated
                                                            */
        }
    }

   

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise7 : MonoBehaviour
{
    public string sum, subtraction, product, division;
    public float a = 5f;
    public float b = 3f;



    private float result;
    private void Start()
    {
        result = a + b;
        Debug.Log(result);  //sum

        result = a - b;
        Debug.Log(result);  //subtraction

        result = a * b;
        Debug.Log(result);  //product

        result = a / b;
        Debug.Log(result);  //division


    }


}

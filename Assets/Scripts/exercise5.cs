using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise5 : MonoBehaviour
{
    public int age = 19;

    private void Start()
    {
        if (age > 18) //age comparison
        {
            Debug.Log($"Hello, you are {age} years old, so you are of legal age"); //age is greater than the age of majority
        }
        else
        {
            Debug.Log($"Hello, you are {age} years old, so you are not of legal age"); //age is less than the age of majority
        }
    }
}

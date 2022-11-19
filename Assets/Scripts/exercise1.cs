using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour
{
    public float number = 5f;

    private void Start()
    {
        if (number > 0)
        {
            Debug.Log($"The number {number} is positive");
        }else if (number == 0)   //if it is not positive, it is zero or negative
        {
            Debug.Log($"The number {number} is zero");
        }
        else   //if it is neither positive nor zero, it is negative
        {
            Debug.Log($"The number {number} is negative");
        }
    }
}

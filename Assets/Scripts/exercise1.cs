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
        }else if (number == 0)
        {
            Debug.Log($"The number {number} is zero");
        }
        else
        {
            Debug.Log($"The number {number} is negative");
        }
    }
}

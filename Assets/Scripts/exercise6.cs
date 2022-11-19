using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise6 : MonoBehaviour
{
    public float distanceTraveled = 50;
    public float totalDistance = 200;

    private void Start()
    {
        if(distanceTraveled < totalDistance)   //distance comparison
        {
            Debug.Log("Oh...You still have 150 meters left to complete the total distance");  //has not yet completed the full distance
        }
        else
        {
            Debug.Log("Congratulations! You have completed the total distance.");   //instead, it is completed
        }
    }
}

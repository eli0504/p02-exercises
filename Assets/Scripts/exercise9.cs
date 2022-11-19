using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise9 : MonoBehaviour
{
    public bool wantsVegetarianOption;

    private void Start()
    {
        if(wantsVegetarianOption != true)  //inequality
        {
            Debug.Log("Non-vegetarian option coming soon");
        }
        else
        {
            Debug.Log("Vegetarian option coming soon");  //becomes true
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour
{
    public int number = 10;

    private void Start()
    {
        if (number % 5 != 0 && number % 5 != 5 && number % 5 != 10 && number % 5 != 15 && number % 5 != 20 && number % 5 != 25 && number % 5 != 30 && number % 5 != 35 && number % 5 != 40 && number != 45 && number % 5 != 50 && number % 5 != 55)
        {
            Debug.Log($"The number {number} is not divisible by 5"); /*
                                                                      if the number is not equal to the corresponding number, it is not divisible by 5
                                                                     */
        }
        else
        {
            Debug.Log($"The number {number} is divisible by 5");  /*
                                                                   Otherwise, it would be divisible by 5
                                                                 */
        }
    }
}

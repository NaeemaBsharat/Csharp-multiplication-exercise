using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplication_Table : MonoBehaviour
{

    int Multiply(int number1 , int number2)
    {
         return number1 * number2;
    }
    
    void Start()
    {
        for(int i=1;i<=10;i++)
        {
            int mul_result = Multiply(5, i);
            

            Debug.Log(5 + " x " + i + " = " + mul_result);
        }

        
    }
    void Update()
    {
        
    }
}

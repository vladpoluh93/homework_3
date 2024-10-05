using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Test_Hard : MonoBehaviour

    {
        public bool Minus = false;
        public bool Plus = false;
        public bool Divide = false;
        public bool Multiplication = false;
        public float Number1 = 0.00f;
        public float Number2 = 0.00f;
        public float Result = 0.00f;

    void Start()
        {
        int trueCount = 0;
        if (Minus) trueCount++;
        if (Plus) trueCount++;
        if (Divide) trueCount++;
        if (Multiplication) trueCount++;
        
        if (trueCount > 1)
        {
            Result = float.NaN;
            Debug.Log("You only need to select one operation.");
            return;
        }

        if (Minus == true)
         { 
         Result = MetodMinus(Number1, Number2);
         Debug.Log("Result: " + Result);
         } 
        
        if (Plus == true)
         {
            Result = Number1 + Number2;
            Debug.Log("Result: " + Result);
         }
        if (Divide == true)
         {
            if(Number2 !=0)
             {
             Result = Number1 / Number2;
             Debug.Log("Result: " + Result);
             }
            else 
             {
             Result = float.NaN;
             Debug.Log("It cannot be divided by 0");
            }
        }
        if (Multiplication == true)
         {
         Result = Number1 * Number2;
         Debug.Log("Result: " + Result);
         }
    }
    float MetodMinus(float number1, float number2)
    {

        return number1 - number2;
    }
    }


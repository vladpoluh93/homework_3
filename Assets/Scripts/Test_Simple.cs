using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test_Simple : MonoBehaviour

    {
        public bool Minus = false;
        public bool Plus = false;
        public bool Divide = false;
        public bool Multiplication = false;
        public float Number1 = 0.00f;
        public float Number2 = 0.00f;
        
        
        void Start()
        {
            if (Minus == true)

            {
                Debug.Log ( Number1 - Number2);
            }
            if (Plus == true)

            {
                Debug.Log ( Number1 + Number2);
            }
            if (Divide == true)

            {
                 if (Number2 != 0) 
                { 
                 Debug.Log ( Number1 / Number2);
                 }
                 else
                {           
                Debug.Log("It cannot be divided by 0");
                }

            }
            if (Multiplication == true)

            {
                Debug.Log ( Number1 * Number2);
            }
            
        }
    }


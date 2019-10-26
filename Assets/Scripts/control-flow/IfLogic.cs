using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfLogic : MonoBehaviour
{

    public int myAge = 31;

    void Start()
    {
        /*
        if (CONDITION)
        {
            CODE
        }
        */

        if (myAge >= 17)
        {
            Debug.Log("You can drive");
        }
        else if (myAge < 0)
        {
            Debug.Log("Not a real age");
        }
        else
        {
            Debug.Log("You can't drive");
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar Hit");
        }
    }
}

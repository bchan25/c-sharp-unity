using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddApples : MonoBehaviour
{
    public int apples;

    
    void Start()
    {
        StartCoroutine(AddApplesRoutine());    
    }


    // Great for pausing code
    IEnumerator AddApplesRoutine()
    {
        for(int i = 0; i < 100; i++)
        {
            apples++;
            yield return new WaitForSeconds(1.0f);
        }
    }

}

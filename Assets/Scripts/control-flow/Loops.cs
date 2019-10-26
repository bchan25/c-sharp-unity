using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
	public string name = "Ben";

    // Loops good to use with arrays

	void Start()
	{
		// Repeating code based on condition
		for (int i = 0; i < 5; i++)
		{
			Debug.Log("Hello " + name);
		}

		for (int i = 0; i < 100; i++)
		{
            if(i == 50)
			{
                // This will stop the loop early
				break;
			}
			Debug.Log(i);
		}


        // Foreach used with Arrays and Collections

        int x = 0;

        // Loop that run at least once first
        /* 
        do
        {
            Debug.Log("I print at least once");
            x++;
        } while (x < 3);
        */


        while(x < 5)
        {
            Debug.Log(x);
            x++;
        }
    }



}

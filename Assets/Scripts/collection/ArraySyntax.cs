using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySyntax : MonoBehaviour
{
	// Array hold group of data in one variable name
	public string[] names;


    
    void Start()
    {
		// Access the data
		Debug.Log(names[0]);

    }

    
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            // Looping Array
            foreach(var item in names)
            {
                Debug.Log("Hello " + item);
            }
		}        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    /// <summary>
    /// public or private reference
    /// data type (string, int, float, bool) or Unity Components
    /// name
    /// optional -- a value
    /// </summary>
    ///

    // Public can be seen in Inspector
    public string myName = "Ben";
    // Can't be access by other scripts
    private int myAge = 31;
    public string myLocation = "Chester";

    private void Start()
    {
        // Value can change
        myAge += 1;

        // Print using variable
        Debug.Log("Hello " + myName + ". Your " + myAge + " years old and from " + myLocation + ".");
    }
}

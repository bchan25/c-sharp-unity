using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public int answer;

    void Start()
    {
        // Call Method
        SayHello();
        Shout("HELP!");

        answer = Add(5, 4);
    }

    

    // Your Method
    private void SayHello()
    {
        Debug.Log("Hello");
    }

    private void Shout(string word)
    {
        Debug.Log(word);
    }

    private int Add(int a, int b)
    {
        return a + b;
    }

}

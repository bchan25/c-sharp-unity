using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLogic : MonoBehaviour
{
    private int selectedLevel;

    private int _easy = 0;
    private int _medium = 1;
    private int _hard = 2;

    // Start is called before the first frame update
    void Start()
    {
        selectedLevel = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        switch (selectedLevel)
        {
            case 0:
                Debug.Log("Easy!");
                break;
            case 1:
                Debug.Log("Medium");
                break;
            case 2:
                Debug.Log("Hard!!");
                break;
            default:
                Debug.Log("Invalid Selection");
                break;
        }

        // Input to set random level
        if (Input.GetKeyDown(KeyCode.R))
        {
            selectedLevel = Random.Range(0, 3);
        }

        // Input to Invalid Code
        if (Input.GetKeyDown(KeyCode.I))
        {
            selectedLevel = 55;
        }
    }
}

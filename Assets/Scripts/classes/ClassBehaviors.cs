using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Blueprint
public class WeaponStats
{
    public string name;
    public float fireRate;
    public int ammoCount;

    // Construtor To create this object
    public WeaponStats(string name, float fireRate, int ammoCount)
    {
        // This refer to the varibles of this Class
        this.name = name;
        this.fireRate = fireRate;
        this.ammoCount = ammoCount;
    }
}

public class ClassBehaviors : MonoBehaviour
{

    /*
     * OOP
     * Classes for BEHAVIORS like move jump shoot
    */

    private WeaponStats blasters;

    void Start()
    {
        // Create a instance of the Object
        /*
        blasters = new WeaponStats();
        blasters.name = "Blasters";
        blasters.fireRate = 0.25f;
        blasters.ammoCount = 50;
        */

        blasters = new WeaponStats("Blasters", 0.25f, 50);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }



    private void Jump()
    {
        Debug.Log("Jump");
    }

    private void Move()
    {
        Debug.Log("Move");
    }

    private void Look()
    {
        Debug.Log("Look");
    }



}

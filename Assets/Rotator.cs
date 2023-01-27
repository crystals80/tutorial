// Using keywords = using other libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Rotator = name of of class
// MonoBehaviour = base class 
public class Rotator : MonoBehaviour
{

    // Any variable made public → is visible in the settings of Unity
    public float rotationSpeed = 0.3f;
    // Any variable made private → is NOT visible in the settings of Unity
    private bool rotate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If statement → connect Update and FixedUpdate
        /*if(Input.GetKey(KeyCode.R))
        {
            rotate = true;
        }
        else
        {
            rotate = false;
        }*/
    }

     // FixedUpdate guarantees a regular interval and input
    void FixedUpdate()
    {
        /*if (rotate) 
        {*/
        // this refers the "parent" code that this is in
        this.GetComponent<Transform>().Rotate(0, rotationSpeed,0);
        /*}*/
    }
}

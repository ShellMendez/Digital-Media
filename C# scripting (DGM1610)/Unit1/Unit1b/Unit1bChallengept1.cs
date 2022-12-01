using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
//Functions
//Conditionals
//Else Clauses Are included in this project
// Update is called once per frame
//This program Took a Cube and moved it up When I press UpArrow and quit if I pressed q

class Movement : MonoBehaviour
{
    Rigidbody rigidB;

    void Start() //Function of what happens at the very start
    {
        rigidB = GetComponent<Rigidbody>();

    }
    void Update()//Keeeps running basically as a uninterrupted look
    {

        ProcessThrust();

    }

    void ProcessThrust() // Function that Allows me to lift the cube by pressing UpArrow
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetinputKey();

        }
    }

    void GetinputKey()

    {
        //DownArrow 
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidB.AddRelativeForce(0, -1, 0);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidB.AddRelativeForce(0, 1, 0);
            Debug.Log("Pressed SPACE - Thrusting");
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Rotating Right");
        }
        else
        if (Input.GetKey(KeyCode.Q))
        {
            Debug.Log("You quitted");

        }
    }
    void ChangeCubeColor()
    {

    }

}


    //void SetRotation()
    //{
    //    Debug.Log("You have sucessfully Ran Rotation");
    //}
//Functions
//Conditionals
//Else Clauses
//Switches *****************Will create another doc with the switches. This one works XD
//Create new class each time we create a new script and have that script responsible for one thing
//It is a good idea to have one class per script
//Where possible we encapsulate our code and make sure access is only on a need to know basis
//ClassName.MethodName. Unity has class 
//

    //Movement
    //CollisionHandler
    //Shooting
    //Score
    //Enemy

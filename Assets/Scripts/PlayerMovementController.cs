using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{

    public float speed = 10f; //speed is always done in float in unity.
    private Rigidbody2D rigidbodyObject;

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyObject = GetComponent<Rigidbody2D>();  //get the rigid body 2d component of the game object.
    }

    // Update is called once per frame
    void Update()
    {

        //To configure the input manager goto: Unity->File->Project settings->Input Manager
        //here we get wether a/left arrow or d/right arrow key was pressed 
        float horizontalAxisInput = Input.GetAxis("Horizontal");  //the string "Horizontal" is defined in the input manager.
        //value=0(if not triggered), 1(right side), -1(left side)
        
        //here we get wether s/down arrow or w/up arrow key was pressed 
        float verticalAxisInput = Input.GetAxis("Vertical");
        //value=0(if not triggered), 1(up side), -1(down side)

        //To give this input info to the player object:
        // creating a direction object
        Vector2 direction = new Vector2(horizontalAxisInput, verticalAxisInput);


        //setting a normalized speed for our player in the direction h and v(i.e. when h and v keys are pressed at the same time).
        rigidbodyObject.velocity = direction.normalized * speed;
    }

 
}

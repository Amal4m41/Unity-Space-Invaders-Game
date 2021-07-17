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
        //here we get whether a/left arrow or d/right arrow key was pressed 
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


        //Accessing the Animator component of the player object(since this script is attached to the player object).
        GetComponent<Animator>().SetBool("isFlyingLeft", horizontalAxisInput < 0 && verticalAxisInput>0
            || horizontalAxisInput<0); //When horizontal value is -1(moving left) 
            //i.e < 0 the value will be set to true
        GetComponent<Animator>().SetBool("isFlyingUp", verticalAxisInput > 0 && horizontalAxisInput==0); 
        GetComponent<Animator>().SetBool("isFlyingDown", verticalAxisInput < 0); 
        GetComponent<Animator>().SetBool("isFlyingRight", horizontalAxisInput > 0 && verticalAxisInput > 0 
            || horizontalAxisInput>0); 
    }

 
}

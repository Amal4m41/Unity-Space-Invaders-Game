using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    //invoked when another rigidbody2d/collider2d collides with this game object's collider(parameter is the other
    //game object's collider)
    private void OnCollisionEnter2D(Collision2D collision)   
    {
        //Debug.Log("Collision with wall");


//        if (collision.gameObject.name != "PlayerMoveUp")   OR
        if (collision.gameObject.tag != "Player")
        {
            //collision.gameObject is the incoming gameobject involved in the collision with the gameobject holding
            //this script
            Destroy(collision.gameObject);  //removes a component, asset or gameobject.
        
        }
        //Destroy(gameObject);  //This will destroy this gameobject itself when something collides with it,
        //that is the wall in our case.
    }
}

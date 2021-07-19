using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity; //give us the direction for which the item we assign should move.(magnitude and direction)
    new Rigidbody2D rigidbody;  //get the rigid body2d component of the game object that holds this script.

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()  //called every fixed frame rate whereas the Update() is called every frame.
    {
        rigidbody.velocity = velocity;
    }
}

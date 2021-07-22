using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    public float speed = 7; // the speed of the gameobject that moves towards the player

    // Start is called before the first frame update
    void Start()  
    {
        //putting the code in start() so that only when the object is created it gets the velocity,
        //otherwise the bullets will change it's direction and follow the player after every frame update if we put it
        //in the Update()

        GameObject gameobjectPlayer = GameObject.FindWithTag("Player");  //find the gameobject with tag value "Player"    
        //Debug.Log(gameobject.name);
        //transform.position is the position of the gameobject holding this script
        //gameObject.transform.position  is the position of the gameobject which is our player.
        Vector3 v3 = (gameobjectPlayer.transform.position - this.transform.position).normalized; //3d vector cuz the position of the player is a 3d position

        Vector2 v2 = new Vector2(v3.x, v3.y);

        Debug.Log(gameobjectPlayer.transform.position);
        Debug.Log(this.transform.position);
        //Attach the velocity to the rigid body of the gameobject that holds this script
        GetComponent<Rigidbody2D>().velocity = v2 * speed;
    }
}

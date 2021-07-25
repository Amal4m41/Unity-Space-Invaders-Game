using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            //if the player object collides with the player or the player bullet, ignore the collision

                                     //Collider of the object this bullet collides with, this bullet's collider.
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(),GetComponent<Collider2D>());
            //Above line says to ignore the collision between the colliders of the 1st the Player/Bullet gameobject,
            //2nd the collider of the gameobject that holds this script.
        }
        else
        {
            Destroy(gameObject);  //destroy the gameobject that holds this script
            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);   //if the colliding gameobject is not a wall destroy that too.
            }
        }
    }
}

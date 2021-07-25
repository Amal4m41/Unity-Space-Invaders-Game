using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster")
        {
            Destroy(gameObject); //if the playerobject gets hit with the monsters, kill the player
        }
        else if (collision.gameObject.tag == "MonsterBullet")
        {// if the playerobject gets hit with the monster bullet, kill the player and the monster bullet.
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        
    }
}

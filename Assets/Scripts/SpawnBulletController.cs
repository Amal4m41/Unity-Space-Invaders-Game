using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{

    public GameObject bullet; //the game object(bullet) that we want to control, generate etc. (VERY IMP: GET THE OBJECT FROM PREFAB FOLDER)
    public float interval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //To invoke a method intially after 5 second, then every one second.
        //InvokeRepeating("ShootBullet", 5f, 1f);
        
        InvokeRepeating("ShootBullet", interval, interval);  //invoke the function after every interval
    }



    private void ShootBullet()
    {
        //create a clone of the bullet gameobject, at the position of the parent(the object to which the script is attached)
        //and rotation as identity
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity); 
    }
}

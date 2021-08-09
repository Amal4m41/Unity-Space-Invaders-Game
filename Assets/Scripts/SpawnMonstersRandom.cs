using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonstersRandom : MonoBehaviour
{
    public GameObject[] monster; //the game object(monster) that we want to control, generate etc. (VERY IMP: GET THE OBJECT FROM PREFAB FOLDER)
    public float interval = 3f;
    public float startInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //To invoke a method intially after 5 second, then every one second.
        //InvokeRepeating("ShootBullet", 5f, 1f);

        InvokeRepeating("CreateMonster", startInterval, interval);  //invoke the function after every interval
    }

    /* Method -1
    //This script will be places inside the Wall Parent game object
    private void CreateMonster()
    {
        //create a clone of the bullet gameobject, at the position of the parent(the object to which the script is attached)
        //and rotation as identity
        GameObject g = Instantiate(monster[0],new Vector2(Random.Range(-9,9),Random.Range(10,15)), Quaternion.identity);
        GameObject g2 = Instantiate(monster[1], new Vector2(Random.Range(-9, 9), Random.Range(10, 15)), Quaternion.identity);
    }
    */

    //Method 2
    private void CreateMonster()
    {
        float randomValue = Random.value; //return a random value from 0.0 to 1.0

        if (randomValue <= 0.1) 
        {
            //Spawns monster1 10% of the time
            //transform.position is the origin position of this gameobject's(the object holding this script) parent
            GameObject g = Instantiate(monster[0],transform.position, Quaternion.identity);
        }
        else if(randomValue <= 0.2)
        {
            //Spawns monster2 10% of the time
            GameObject g2 = Instantiate(monster[1],transform.position, Quaternion.identity);
        }
        else
        {
            //Spawn nothing 80% of the time. 
        }
    }
}

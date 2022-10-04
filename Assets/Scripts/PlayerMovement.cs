using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject playerHealth;
    PlayerHealth playerHealth;
     int speed = 10;

   void Start()
    {
        // Debug.Log(playerHealth.GetComponent<PlayerHealth>().playerHealth);
        playerHealth = GetComponent<PlayerHealth>(); 
    }
    //public enum 
    // Update is called once per frame
    void Update()
    {
         if (playerHealth.playerHealth > 0) { 

        if (Input.GetKey(KeyCode.W))
        {

            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);

        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position += new Vector3(-speed * Time.deltaTime, 0f,  0f);

        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position += new Vector3( 0f, - speed * Time.deltaTime, 0f);

        }
            if (Input.GetKey(KeyCode.D))
            {

                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
        }
        //if your fps is 60, deltaTime =1/60
        //if fps is 60, Udate runs 60 times per second
        //1/60 * 1 called 60 imes = 1;
    }
}

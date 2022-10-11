using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public GameObject playerHealth;
    PlayerHealth playerHealth;
   public int speed = 10;
    public int score;

    private void Awake()
    {
        score = 0;
    }
    void Start()
    {
        // Debug.Log(playerHealth.GetComponent<PlayerHealth>().playerHealth);
        //playerHealth = GetComponent<PlayerHealth>(); 
    }
    //public enum 
    // Update is called once per frame
    void Update()
    {
        
        

            if (Input.GetKey(KeyCode.W))
            {

                transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);

            }
            if (Input.GetKey(KeyCode.A))
            {

                transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);

            }
            if (Input.GetKey(KeyCode.S))
            {

                transform.position += new Vector3(0f, -speed * Time.deltaTime, 0f);

            }
            if (Input.GetKey(KeyCode.D))
            {

                transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
        
        //if your fps is 60, deltaTime =1/60
        //if fps is 60, Udate runs 60 times per second
        //1/60 * 1 called 60 imes = 1;
    }
    //1. Both objects must have collider
    //2. Atleast one object must be marked as a trigger
    //3. Atleast one objectinvolved has a rigidbody

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("OnTriggerEnter2D colided with:");
        //if (collider.CompareTag("Coin"))
        //{
        //    score++;
        //    Destroy(collider.gameObject);
        //}

        Coin coin = collider.GetComponent<Coin>();
        if (coin != null)
        {
            Debug.Log("Colidd object has Coin Compoenet");
            score += coin.points;
            coin.DestroySelf();

        }


    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("OnTriggerStay2D");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("OnTriggerExit2D");
    }
    

    //1.Both objects must have a collider
    //2. Both objects CANNOT be a triger
    //3. At least one object must have a DYNAMIC(non kinematic) rigidbody
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.GetComponent<Coin>();   
    }

}

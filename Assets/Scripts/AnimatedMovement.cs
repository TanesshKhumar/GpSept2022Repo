using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedMovement : MonoBehaviour


{
    public float speed = 10;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == false)
        {
            animator.SetBool("Walk", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            animator.SetTrigger("Taunt");
        }



        if (Input.GetKey(KeyCode.W))
        {

            transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
            animator.SetBool("Walk", true);
        }
        if (Input.GetKey(KeyCode.A))
        {

            transform.position += new Vector3(-speed * Time.deltaTime, 0f, 0f);
            animator.SetBool("Walk", true);
        }
        if (Input.GetKey(KeyCode.S))
        {

            transform.position += new Vector3(0f, -speed * Time.deltaTime, 0f);
            animator.SetBool("Walk", true);
        }
        if (Input.GetKey(KeyCode.D))
        {

            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
            animator.SetBool("Walk", true);
        }




    }
}

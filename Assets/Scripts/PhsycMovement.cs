using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhsycMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {



        }
        if (Input.GetKey(KeyCode.A))
        {

            rb.AddForce(new Vector2(-1f * speed, 0f));

        }
        if (Input.GetKey(KeyCode.S))
        {



        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(1f * speed, 0f));


        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0f, 1f * speed), ForceMode2D.Impulse);


        }
    }
}

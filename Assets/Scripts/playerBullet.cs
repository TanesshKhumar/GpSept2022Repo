using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet : MonoBehaviour
{
    public float speed;


    private void Start()
    {
        Destroy(gameObject, 3f);
    }



    void Update()
    {
        transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
    }

   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastDemo : MonoBehaviour
{
    public float distance;
    public LayerMask layerToIgnore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Fired raycast");
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector3.up, distance, ~layerToIgnore);
            Debug.DrawRay(transform.position, Vector3.up * distance, Color.red, 3f);

            if(hitInfo.collider != null)
            {
                Debug.Log("Hit" + hitInfo.collider.name);
            }
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{ 
public CSharpDemo scoreManager;
   public int playerHealth = 10;
    public GameObject spriteColour;

    void TakeDamage()
    {
        playerHealth -= 1;

        if (playerHealth > 0)
        {
           
            Debug.Log("You have taken Damage "+ playerHealth);
        }
        else if (playerHealth == 0)
        {
            Debug.Log("You have died cb");
            GetComponent< SpriteRenderer > ().color = Color.red; 
        }

    }

    void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            TakeDamage();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

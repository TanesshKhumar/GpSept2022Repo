using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points;


    public void DestroySelf()
    {

        Destroy(gameObject);

    }
}

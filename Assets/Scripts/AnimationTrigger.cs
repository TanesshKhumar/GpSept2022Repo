using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public void TriggerInvul()
    {
        Debug.Log("Call Mom");
    }


    public void TriggerInvul(int input, bool test)
    {

        if (input == 1)
        {
            Debug.Log("Val" + input);
        }

        else
        {
            Debug.Log("mhm");
        }

    }
}

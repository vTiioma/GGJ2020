using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public bool isOneIn = false;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (isOneIn)
            {
                Victory();
            }
            else
            {
                isOneIn = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isOneIn = false;
    }
    void Victory()
    {
        Debug.Log("You won, Congratulations i guess. Are you happy with yourself now? Did this few endophines made your life a little bit more worth all the hassel? I sure hope so becaiuse that's about it. Jk. Th longest debug log that i ever wrote. This may be the ending screen. I mean it feels right");
    }
}

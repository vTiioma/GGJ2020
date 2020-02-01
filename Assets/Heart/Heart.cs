using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart : MonoBehaviour
{
    public int isOneIn = 0;
    public int levelIndex = 2;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (isOneIn == 2)
            {
                Victory();
            }
            else
            {
                isOneIn++;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isOneIn--;
    }
    void Victory()
    {
        Debug.Log("You won, Congratulations i guess. Are you happy with yourself now? Did this few endophines made your life a little bit more worth all the hassel? I sure hope so becaiuse that's about it. Jk. Th longest debug log that i ever wrote. This may be the ending screen. I mean it feels right");
        Scene.ResetScene();
        LevelLoader.LoadNextLevel();
        Destroy(this);
    }
}

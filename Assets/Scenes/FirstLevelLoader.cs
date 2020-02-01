using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.anyKey || Input.GetMouseButton(0))
        {
            LevelLoader.LoadNextLevel();
        }
    }
}

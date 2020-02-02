using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLevelLoader : MonoBehaviour
{
    // Start is called before the first frame update
    public void Update()
    {
        if (Input.anyKey || Input.GetMouseButton(0))
        {
            LevelLoader.LoadFirstLevel();
            Destroy(this);
        }
    }
}

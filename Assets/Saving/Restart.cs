using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Restart : MonoBehaviour
{
    [SerializeField]
    GameObject temporaryScene, scenePrefab;
    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }
    public void RestartLevel()
    {
        Destroy(temporaryScene);
        Scene.CleanList();
        Scene.ResetScene();
        temporaryScene = Instantiate(scenePrefab);
    }
}

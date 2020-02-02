using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelLoader
{
    static int buildIndex = 1;

    public static void LoadNextLevel()
    {
        Debug.Log($"Unload {buildIndex}" );
        SceneManager.UnloadSceneAsync(buildIndex);
        if(buildIndex == 3)
        {
            SceneManager.LoadSceneAsync("demo");
            return;
        }
        buildIndex++;
        SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
    }

    public static void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync("MainScene");
    }
}

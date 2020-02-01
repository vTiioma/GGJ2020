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
        buildIndex++;
        SceneManager.LoadSceneAsync(buildIndex, LoadSceneMode.Additive);
    }

    public static void LoadFirstLevel()
    {
        SceneManager.LoadSceneAsync("levelOne", LoadSceneMode.Additive);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(FreezeAGame());
    }
    IEnumerator FreezeAGame()
    {
        Time.timeScale = 0.01f;
        yield return new WaitForSeconds(0.01f);
        Time.timeScale = 1f;
    }
}

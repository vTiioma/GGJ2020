using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Heart : MonoBehaviour
{
    public int isOneIn = 0;
    public int levelIndex = 2;
    public Color good, bad;
    public MeshRenderer renderer;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            if (isOneIn >= 2)
            {
                Material material = renderer.material;
                material = new Material(material);
                material.SetFloat("_Brightness", 1);
                renderer.material = material;
                Victory();
            }
            else
            {
                isOneIn++;
                ChangeColor(good);
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            LevelLoader.LoadNextLevel();
        }
    }
    void ChangeColor(Color color)
    {
        Material material = renderer.material;
        material = new Material(material);
        material.SetColor("_Color", color);
        renderer.material = material;
    }
    private void OnTriggerExit(Collider other)
    {
        isOneIn--;
        ChangeColor(bad);
    }
    void Victory()
    {
        Debug.Log("You won, Congratulations i guess. Are you happy with yourself now? Did this few endophines made your life a little bit more worth all the hassel? I sure hope so becaiuse that's about it. Jk. Th longest debug log that i ever wrote. This may be the ending screen. I mean it feels right");
        Scene.ResetScene();
        Scene.sound.Victory();
        StartCoroutine(LoadNextLevel());
    }

    IEnumerator LoadNextLevel()
    {
        Time.timeScale = 0.1f;
        yield return new WaitForSeconds(0.1f);
        Time.timeScale = 1;
        LevelLoader.LoadNextLevel();
        Destroy(this);
    }
}

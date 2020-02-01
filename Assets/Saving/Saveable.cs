using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saveable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent = Scene.staticScene;
    }
}

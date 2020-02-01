using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Scene.staticScene = this.transform;
    }
}

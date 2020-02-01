using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saveable : MonoBehaviour
{
    public int lifespan = 5;
    public int current = 1;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.parent = Scene.staticScene;
        Scene.savedObjects.Add(this);
    }
    public void GetOlder() {
        current++;
        if (!this)
        {
            return;
        }
        if(current >= lifespan && this.gameObject)
        {
            Destroy(this.gameObject);
        }
    }

}

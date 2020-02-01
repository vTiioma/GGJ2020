using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourChanger : MonoBehaviour
{
    public Component component;
    // Start is called before the first frame update
    void Start()
    {
        ChangeableObjects.changers.Add(this);
    }

    public void ChangeComponent(System.Type newComponent)
    {
        Destroy(component);
        this.gameObject.AddComponent(newComponent);
        component = this.gameObject.GetComponent(newComponent);
    }
}

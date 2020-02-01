using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangableObject : MonoBehaviour
{
    public string objectName = "block";
    public List<Component> components = new List<Component>();
    // Start is called before the first frame update
    void Awake()
    {
        Scene.changableObjects.Add(this);
    }

    public void RemoveComponent(System.Type type)
    {
        List<Component> componentsToRemove = new List<Component>();
        foreach(var c in components)
        {
            if(c.GetType() == type)
            {
                componentsToRemove.Add(c);
            }
        }
        foreach(var c in componentsToRemove)
        {
            components.Remove(c);
        }
    }

    public void AddComponent(System.Type type)
    {
        Component newComponent = this.gameObject.AddComponent(type);
        components.Add(newComponent);
    }
}

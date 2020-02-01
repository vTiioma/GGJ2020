using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Scene
{
    public static List<ChangableObject> changableObjects = new List<ChangableObject>();

    public static void RemoveFrom(Component com, string name)
    {
        CleanList();
        foreach(var c in changableObjects)
        {
            if(c.objectName == name)
            {
                c.RemoveComponent(com.GetType());
            }
        }
    }

    public static void AddTo(Component com, string name)
    {
        CleanList();
        foreach (var c in changableObjects)
        {
            if (c.objectName == name)
            {
                c.AddComponent(com.GetType());
            }
        }
    }

    static void CleanList()
    {
        for(int i=0; i < changableObjects.Count; i++)
        {
            if (!changableObjects[i])
            {
                changableObjects.RemoveAt(i);
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ChangableObject;

public static class Scene
{
    public static List<ChangableObject> changableObjects = new List<ChangableObject>();
    public static Transform staticScene;
    public static List<Saveable> savedObjects = new List<Saveable>();
    public static void RemoveFrom(Component com, PossibleMaterials material)
    {
        CleanList();
        foreach(var c in changableObjects)
        {
            if(c.dropDown == material)
            {
                c.RemoveComponent(com.GetType());
            }
        }
    }

    public static void AddTo(Component com, PossibleMaterials material)
    {
        CleanList();
        foreach (var c in changableObjects)
        {
            if (c.dropDown == material)
            {
                c.AddComponent(com.GetType());
            }
        }
    }

    public static void CleanList()
    {
        for(int i=0; i < changableObjects.Count; i++)
        {
            if (!changableObjects[i])
            {
                changableObjects.RemoveAt(i);
            }
        }
    }

    public static void ResetScene()
    {
        changableObjects.Clear();
        foreach (var s in savedObjects)
        {
            s.GetOlder();
            changableObjects.Add(s.gameObject.GetComponent<ChangableObject>());
        }
    }
}

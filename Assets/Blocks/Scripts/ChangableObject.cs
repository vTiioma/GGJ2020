﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangableObject : MonoBehaviour
{
    public Vector3 directionOfPotentiallMovment = new Vector3(1, 1, 0);
    public enum PossibleMaterials
    {
       Wood,
       Stone,
       Glass,
       Pear
    };
    public PossibleMaterials dropDown = PossibleMaterials.Stone;
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

        while(componentsToRemove.Count > 0)
        {
            var c = componentsToRemove[0];
            componentsToRemove.Remove(c);
            components.Remove(c);
            Destroy(c);
        }
    }

    public void AddComponent(System.Type type)
    {
        if (this.gameObject != null)
        {
            Component newComponent = this.gameObject.AddComponent(type);
            components.Add(newComponent);
        }
    }
}

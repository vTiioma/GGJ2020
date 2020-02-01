using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ComponenetManager : MonoBehaviour
{
    [SerializeField]
    private List<Component> components;

    private void OnValidate()
    {
        GetAllComponents();
    }

    private void GetAllComponents()
    {
        components = new List<Component>(GetComponents<Component>());
    }

    public bool TryAddComponent(Type type)
    {
        if (HasComponent(type))
        {
            var component = gameObject.AddComponent(type);
            components.Add(component);
            return true;
        }
        return false;
    }

    public bool TryRemoveComponent(Type type)
    {
        if (HasComponent(type))
        {
            var component = GetComponent(type);
            components.Remove(component);
            Destroy(component);
            return true;
        }
        return false;
    }

    public bool HasComponent(Type type)
    {
        return components.FirstOrDefault(x => x.GetType() == type) != null;
    }
}

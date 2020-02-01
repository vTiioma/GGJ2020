using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ChangeableObjects 
{
    public static List<BehaviourChanger> changers = new List<BehaviourChanger>();

    public static void ChangeFromTo(System.Type from, System.Type to)
    {
        foreach (var c in changers)
        {
            if(c.component.GetType() == from)
            {
                Debug.Log("isEqual");
                c.ChangeComponent(to);
            }
        }

    }
}



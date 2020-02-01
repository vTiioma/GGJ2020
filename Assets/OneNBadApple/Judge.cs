using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judge : MonoBehaviour
{
    public Component fromComponent, toComponent;
    public System.Type from, to;

    private void Start()
    {
        from = fromComponent.GetType();
        to = toComponent.GetType();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Change Rules " + ChangeableObjects.changers.Count.ToString());
        ChangeableObjects.ChangeFromTo(from, to);
    }
}

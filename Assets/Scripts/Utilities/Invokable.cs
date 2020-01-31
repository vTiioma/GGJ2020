using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Invokable : MonoBehaviour
{
    public UnityEvent callback = new UnityEvent();

    [ContextMenu("Force Invoke")]
    public void Invoke()
    {
        callback?.Invoke();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnStart : MonoBehaviour
{
    public UnityEvent callback = new UnityEvent();

    private void Start()
    {
        callback?.Invoke();
    }
}

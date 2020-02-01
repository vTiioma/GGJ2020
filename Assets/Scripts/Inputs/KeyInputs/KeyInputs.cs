using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyInputs : MonoBehaviour
{
    [SerializeField]
    private KeyCode key = KeyCode.A;
    [Space]
    [Space]
    [Space]
    public UnityEvent onKeyDown = new UnityEvent();
    public UnityEvent onKeyUp = new UnityEvent();

    private void OnKeyDown()
    {
        onKeyDown?.Invoke();
    }

    private void OnKeyUp()
    {
        onKeyUp?.Invoke();
    }

    public KeyCode GetKeyCode()
    {
        return key;
    }

    private void Update()
    {
        if (Input.GetKeyDown(key))
        {
            OnKeyDown();
        }
        if (Input.GetKeyUp(key))
        {
            OnKeyUp();
        }
    }
}

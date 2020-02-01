using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputHandler : MonoBehaviour
{
    [SerializeField]
    private string identifier = string.Empty;
    [Space]
    [Space]
    [Space]
    public UnityEvent onInput = new UnityEvent();

    public string GetIdentifier()
    {
        return identifier;
    }

    protected void SetIdentifier(string value)
    {
        identifier = value;
    }

    public void OnInput()
    {
        onInput?.Invoke();
    }

    public void Subscribe(UnityAction callback)
    {
        onInput.AddListener(callback);
    }

    public void Unsubscribe(UnityAction callback)
    {
        onInput.RemoveListener(callback);
    }
}

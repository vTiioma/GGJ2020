using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class ValueTracker<T> : ScriptableObject
{
    private class OnValueChangeEvent<T>: UnityEvent<T> {}

    private OnValueChangeEvent<T> onValueChange = new OnValueChangeEvent<T>();
    [SerializeField]
    protected T value;

    public void OnValueChange()
    {
        onValueChange?.Invoke(value);
    }

    public T GetValue()
    {
        return value;
    }

    public void SetValue(T value)
    {
        this.value = value;
        OnValueChange();
    }

    public void Subscribe(UnityAction<T> callback)
    {
        onValueChange?.AddListener(callback);
    }

    public void Unsubscribe(UnityAction<T> callback)
    {
        onValueChange?.RemoveListener(callback);
    }
}

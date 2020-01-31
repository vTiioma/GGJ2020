using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatTracker : ValueTracker<float>
{
    public void UpdateValue(float value)
    {
        SetValue(GetValue() + value);
    }
}

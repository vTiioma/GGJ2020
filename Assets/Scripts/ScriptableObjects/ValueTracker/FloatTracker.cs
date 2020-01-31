using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatTracker : ValueTracker<float>
{
    public void Update(float value)
    {
        SetValue(GetValue() + value);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLeftInput : SwipeInput
{
    private void OnValidate()
    {
        SetIdentifier(InputConstants.left);
    }

    protected override bool IsWithinSwipeThreshold(Vector2 position)
    {
        float delta = position.x - downPosition.x;
        Debug.Log($"{GetIdentifier()}: {delta}");
        if (delta < 0 && Mathf.Abs(delta) >= GetSwipeThreshold())
        {
            return true;
        }
        return false;
    }
}

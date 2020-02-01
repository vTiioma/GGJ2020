using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRightInput : SwipeInput
{
    private void OnValidate()
    {
        SetIdentifier(InputConstants.right);
    }

    protected override bool IsWithinSwipeThreshold(Vector2 position)
    {
        float delta = position.x - downPosition.x;
        Debug.Log($"{GetIdentifier()}: {delta}");
        if (delta > 0 && Mathf.Abs(delta) >= GetSwipeThreshold())
        {
            return true;
        }
        return false;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDownInput : SwipeInput
{
    private void OnValidate()
    {
        SetIdentifier(InputConstants.down);
    }

    protected override bool IsWithinSwipeThreshold(Vector2 position)
    {
        float delta = position.y - downPosition.y;
        Debug.Log($"{GetIdentifier()}: {delta}");
        if (delta < 0 && Mathf.Abs(delta) >= GetSwipeThreshold())
        {
            return true;
        }
        return false;
    }
}

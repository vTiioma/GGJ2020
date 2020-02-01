using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class SwipeInput : InputHandler
{
    [SerializeField]
    private float swipeThreshold = 1;
    protected Vector2 downPosition { get; private set; }


    public void SetSwipeThreshold(float value)
    {
        swipeThreshold = value;
    }

    public float GetSwipeThreshold()
    {
        return swipeThreshold;
    }

    protected void SetDownTapPosition(Vector2 position)
    {
        downPosition = position;
    }

    protected abstract bool IsWithinSwipeThreshold(Vector2 position);

    protected virtual void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SetDownTapPosition(Input.mousePosition);
        }
        if (Input.GetMouseButtonUp(0) && IsWithinSwipeThreshold(Input.mousePosition))
        {
            OnInput();
        }
    }
}

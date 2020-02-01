using UnityEngine;

public class SwipeUpInput : SwipeInput
{
    protected override bool IsWithinSwipeThreshold(Vector2 position)
    {
        float delta = position.y - downPosition.y;
        if (delta > 0 && Mathf.Abs(delta) >= GetSwipeThreshold())
        {
            return true;
        }
        return false;
    }
}

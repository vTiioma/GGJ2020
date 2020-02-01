using UnityEngine;

public class SwipeUpInput : SwipeInput
{
    private void OnValidate()
    {
        SetIdentifier(InputConstants.up);
    }

    protected override bool IsWithinSwipeThreshold(Vector2 position)
    {
        float delta = position.y - downPosition.y;
        Debug.Log($"{GetIdentifier()}: {delta}");
        if (delta > 0 && Mathf.Abs(delta) >= GetSwipeThreshold())
        {
            return true;
        }
        return false;
    }
}

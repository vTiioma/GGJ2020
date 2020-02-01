using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float amount = 1;
    [SerializeField]
    private float duration = 0.25f;

    [ContextMenu("Force MoveUp")]
    public void MoveUp()
    {
        LeanTween.moveY(gameObject, transform.position.y + amount, duration);
    }

    [ContextMenu("Force MoveDown")]
    public void MoveDown()
    {
        LeanTween.moveY(gameObject, transform.position.y - amount, duration);
    }

    [ContextMenu("Force MoveLeft")]
    public void MoveLeft()
    {
        LeanTween.moveX(gameObject, transform.position.x - amount, duration);
    }

    [ContextMenu("Force MoveRight")]
    public void MoveRight()
    {
        LeanTween.moveX(gameObject, transform.position.x + amount, duration);
    }
}

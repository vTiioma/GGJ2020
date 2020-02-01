using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMovementController))]
public class PlayerInputManager : MonoBehaviour
{
    [SerializeField]
    private PlayerMovementController movement;
    private void OnValidate()
    {
        movement = GetComponent<PlayerMovementController>();
    }

    private void Start()
    {
        var inputs = InputManager.instace;
        inputs.GetInput(InputConstants.up).Subscribe(movement.MoveUp);
        inputs.GetInput(InputConstants.down).Subscribe(movement.MoveDown);
        inputs.GetInput(InputConstants.left).Subscribe(movement.MoveLeft);
        inputs.GetInput(InputConstants.right).Subscribe(movement.MoveRight);
    }

    private void OnDestroy()
    {
        var inputs = InputManager.instace;
        inputs.GetInput(InputConstants.up).Unsubscribe(movement.MoveUp);
        inputs.GetInput(InputConstants.down).Unsubscribe(movement.MoveDown);
        inputs.GetInput(InputConstants.left).Unsubscribe(movement.MoveLeft);
        inputs.GetInput(InputConstants.right).Unsubscribe(movement.MoveRight);
    }
}

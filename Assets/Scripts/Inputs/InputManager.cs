using System.Linq;
using UnityEngine;

public class InputManager : Singleton<InputManager>
{
    [SerializeField]
    private InputHandler[] inputs;

    private void OnValidate()
    {
        TryFindAllInputs();
    }

    private void Start()
    {
        TryFindAllInputs();
    }

    private void TryFindAllInputs()
    {
        inputs = GetComponentsInChildren<InputHandler>();
    }

    public InputHandler GetInput(string identifier)
    {
        return inputs.FirstOrDefault(x => x.GetIdentifier() == identifier);
    }
}

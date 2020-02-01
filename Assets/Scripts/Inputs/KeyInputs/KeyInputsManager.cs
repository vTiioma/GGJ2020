using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class KeyInputsManager : Singleton<KeyInputsManager>
{
    [SerializeField]
    private KeyInputs[] inputs;

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
        inputs = GetComponentsInChildren<KeyInputs>();
    }

    public KeyInputs GetInputForKey(KeyCode key)
    {
        return inputs.FirstOrDefault(x => x.GetKeyCode() == key);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static ChangableObject;

public class RuleChanger : MonoBehaviour
{
    public bool isAdding = true;
    public Component com;
    public PossibleMaterials material = PossibleMaterials.Stone;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("Object has entered the trigger");
        if(isAdding)
        {
            Scene.AddTo(com, material);
        }
        else
        {
            Scene.RemoveFrom(com, material);
        }

    }

}

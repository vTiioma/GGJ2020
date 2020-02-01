using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleChanger : MonoBehaviour
{
    public bool isAdding = true;
    public Component com;
    public string material;
    // Start is called before the first frame update
    private void OnTriggerEnter()
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

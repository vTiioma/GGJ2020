using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangableObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        this.gameObject.AddComponent<BehaviourChanger>().component = this;
    }
}

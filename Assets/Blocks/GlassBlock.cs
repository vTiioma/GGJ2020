using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlassBlock : MonoBehaviour
{
    public void Start()
    {
        this.gameObject.AddComponent<BehaviourChanger>().component = this;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}

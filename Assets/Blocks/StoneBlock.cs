using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class StoneBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rgb = this.gameObject.GetComponent<Rigidbody>();
        rgb.isKinematic = true;
    }
}

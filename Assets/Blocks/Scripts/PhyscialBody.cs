using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PhyscialBody : MonoBehaviour
{
    Rigidbody rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = this.gameObject.GetComponent<Rigidbody>();
        rgb.velocity = Vector3.zero;
        rgb.useGravity = true;
        rgb.isKinematic = false;
    }

}

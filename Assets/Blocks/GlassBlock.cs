using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlassBlock : ChangableObject
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}

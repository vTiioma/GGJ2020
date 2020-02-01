using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Points.IncreasePoints();
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    Collider[] colliders;
    public void Start()
    {
        colliders = this.gameObject.GetComponents<BoxCollider>();
        Debug.Log("colliders" + colliders.Length);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //this.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        Debug.Log("Stay");
        if (collision.gameObject.tag == "Player")
        {
            Scene.sound.Point();
            Points.IncreasePoints();
            Destroy(this.gameObject);
        }
    }


}

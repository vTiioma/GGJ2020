using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public void Start()
    {
        this.gameObject.GetComponent<Collider>().isTrigger = true;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Stay");
        if (other.gameObject.tag == "Player")
        {
            Scene.sound.Point();
            Points.IncreasePoints();
            Destroy(this.gameObject);
        }
    }

}

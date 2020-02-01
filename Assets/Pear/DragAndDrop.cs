using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class DragAndDrop : MonoBehaviour
{
    public bool isDragged = false;
    public float distance = 5f;
    public float dragSpeed = 2f;
    public float maxMagnitude = 10f;
    public Rigidbody rgb;

    private void Start()
    {
        rgb = this.gameObject.GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDragged)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, distance));
            Vector3 heading = mousePosition - transform.position;
            heading = Vector3.ClampMagnitude(heading * dragSpeed, maxMagnitude);           
            rgb.velocity = heading;
        }
    }

    public void OnMouseDown()
    {
        isDragged = true;
    }

    public void OnMouseUp()
    {
        isDragged = false;
    }
}

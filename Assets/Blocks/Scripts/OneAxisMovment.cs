﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneAxisMovment : MonoBehaviour
{
    public bool isDragged = false;
    public float distance = 10f;
    public float dragSpeed = 8f;
    public float maxMagnitude = 40f;
    public Rigidbody rgb;

    private void Start()
    {
        rgb = this.gameObject.GetComponent<Rigidbody>();
        rgb.constraints = RigidbodyConstraints.FreezeRotation;
        //rgb.isKinematic = true;
        rgb.useGravity = false;
        rgb.velocity = Vector3.zero;
        rgb.isKinematic = false;
        rgb.constraints = RigidbodyConstraints.FreezePositionZ |
                            RigidbodyConstraints.FreezeRotation;
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
        else
        {
            rgb.velocity = Vector3.zero;
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
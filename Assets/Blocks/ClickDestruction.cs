using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDestruction : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(this.gameObject);
    }
}

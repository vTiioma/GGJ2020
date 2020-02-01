using UnityEngine;

public class freezeoncollide : MonoBehaviour
{
    public GameObject child;

    private void Awake()
    {
        child = transform.GetChild(0).gameObject;
    }
}

using UnityEngine;

public class Singleton<T> : MonoBehaviour where T: UnityEngine.Object
{
    private static T reference;
    public static T instace
    {
        get
        {
            TryGetReference();
            return reference;
        }
    }

    private static void TryGetReference()
    {
        if (reference == null)
        {
            reference = FindObjectOfType<T>();
        }
    }

    protected virtual void Awake()
    {
        TryGetReference();
    }
}

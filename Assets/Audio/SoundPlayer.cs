using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioClip victory, point, destruction, movment;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Scene.sound = this;
    }

    // Update is called once per frame
    public void Victory()
    {
        source.PlayOneShot(victory);
    }
    public void Point()
    {
        source.PlayOneShot(point);
    }
    public void Destruction()
    {
        source.PlayOneShot(destruction);
    }
    public void Movment()
    {
        source.PlayOneShot(movment);
    }

}

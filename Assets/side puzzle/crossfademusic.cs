using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crossfademusic : MonoBehaviour
{
    [SerializeField]
    private AudioSource primary;
    [SerializeField]
    private AudioSource secondary;

    [ContextMenu("Force Crossfade")]
    public void Crossfade()
    {
        secondary.gameObject.SetActive(true);
        LeanTween.value(0, 1, 1.0f).setOnUpdate(LerpMusic).setOnComplete(() => primary.gameObject.SetActive(false)).setIgnoreTimeScale(true);
    }

    private void LerpMusic(float x)
    {
        Debug.Log(x.ToString());
        primary.volume = Mathf.Lerp(0.6f, 0, x);
        secondary.volume = Mathf.Lerp(0, 0.6f, x);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector2(Random.Range(-10, 10), Random.Range(-3, 2.5f));
        transform.localScale = new Vector3(Random.Range(0.5f, 1.25f), Random.Range(0.5f, 1.25f), 1);
        float delta = transform.position.x * 2 / 24;
        LeanTween.moveX(gameObject, -12, Random.Range(10f, 20f) * delta).setOnComplete(AnimateCloud);
    }

    private void AnimateCloud()
    {
        transform.position = new Vector2(12, transform.position.y);
        LeanTween.moveX(gameObject, -12, Random.Range(10f, 20f)).setOnComplete(AnimateCloud);
    }
}

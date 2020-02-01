using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TextUpdateUtility))]
public class ScoreTextUpdateHandler : MonoBehaviour
{
    [SerializeField]
    private TextUpdateUtility text;
    [SerializeField]
    private IntTracker tracker;

    private void OnValidate()
    {
        text = GetComponent<TextUpdateUtility>();
    }

    private void Awake()
    {
        tracker.Subscribe(OnTrackerUpdate);
    }

    private void OnDestroy()
    {
        tracker.Unsubscribe(OnTrackerUpdate);
    }

    private void OnTrackerUpdate(int value)
    {
        text.UpdateText(value.ToString());
    }
}

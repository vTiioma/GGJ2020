using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextUpdateUtility : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private string formatter = string.Empty;

    private void OnValidate()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText(string value)
    {
        if (string.IsNullOrEmpty(formatter))
        {
            text.text = value;
        } else
        {
            text.text = string.Format(formatter, value);
        }
    }
}

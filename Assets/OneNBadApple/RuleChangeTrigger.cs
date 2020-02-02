using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleChangeTrigger : MonoBehaviour
{
    public List<RuleChanger> ruleChangers = new List<RuleChanger>();
    public Color color;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        foreach(var c in ruleChangers)
        {
            c.MakeAnImpact();
        }
        Material material = this.gameObject.GetComponent<MeshRenderer>().material;
        material = new Material(material);
        material.SetColor("_Color", color);
        this.gameObject.GetComponent<MeshRenderer>().material = material;
        Scene.sound.RuleChange();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleChangeTrigger : MonoBehaviour
{
    public List<RuleChanger> ruleChangers = new List<RuleChanger>();
    // Start is called before the first frame update
    public void OnTriggerEnter(Collider other)
    {
        foreach(var c in ruleChangers)
        {
            c.MakeAnImpact();
        }
    }
}

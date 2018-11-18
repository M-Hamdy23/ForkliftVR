using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class WeightUI : MonoBehaviour
{
    TMPro.TextMeshPro text;
    StructureProbs structureProbs;

	// Use this for initialization
	void Start ()
    {
        text = GetComponent<TMPro.TextMeshPro>();

        GameObject root = GetRoot();

        if (root != null)
        {
            structureProbs = GetRoot().GetComponent<StructureProbs>();
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (structureProbs != null)
        {
            text.text = structureProbs.weight.ToString();
        }
	}

    GameObject GetRoot()
    {
        Transform go = transform.parent;

        while (go.parent != null)
        {
            go = go.parent;
        }

        return go.gameObject;
    }
}

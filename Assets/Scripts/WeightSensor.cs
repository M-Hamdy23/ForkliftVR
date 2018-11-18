using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightSensor : MonoBehaviour
{
    public float maxWeight;
    
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Load")
        {
            float loadWeight = other.gameObject.GetComponent<StructureProbs>().weight;

            if (loadWeight > maxWeight)
            {
                print("Too heavy");
            }
        }
    }
}

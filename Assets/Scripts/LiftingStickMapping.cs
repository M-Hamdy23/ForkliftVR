using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftingStickMapping : MonoBehaviour {

    public FloatVariable LiftingStick;
    public float value;
    public GameObject stick;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Mapping()
    {
        LiftingStick.value = value;
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.gameObject.name== stick.name)
        {
            Mapping();
            print("map= " + value);
        }
    }
}

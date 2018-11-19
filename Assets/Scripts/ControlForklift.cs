using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlForklift : MonoBehaviour
{
    Valve.VR.InteractionSystem.Interactable inter;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
	}

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            var rb = other.gameObject.GetComponent<Rigidbody>();

            rb.constraints = RigidbodyConstraints.None;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            var rb = other.gameObject.GetComponent<Rigidbody>();

            rb.constraints = RigidbodyConstraints.FreezeRotationX;
        }
    }
}

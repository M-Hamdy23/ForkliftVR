using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

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

    //private void OnTriggerStay(Collider other)
    //{
    //    //if (other.gameObject.tag == "Hand")
    //    //{
    //        var rb = other.gameObject.GetComponent<Rigidbody>();

    //        rb.constraints = RigidbodyConstraints.None;
    //        Debug.Log("triggerstay");
    //    //}
    //}

    void HandAttachedUpdate(Hand hand)
    {
        var rb = hand.gameObject.GetComponent<Rigidbody>();

        rb.constraints = RigidbodyConstraints.None;
        Debug.Log("HEEEEEEY");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            var rb = other.gameObject.GetComponent<Rigidbody>();

            rb.constraints = RigidbodyConstraints.FreezeRotationX;
            Debug.Log("triggerstay");
        }
    }
}

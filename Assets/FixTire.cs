using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using Valve.VR;

public class FixTire : MonoBehaviour {

    private Hand _hand;                     // The hand object
    private SteamVR_Controller.Device controller; // the controller property of the hand


    void Start()
    {
        // Get the hand componenet
        _hand = GetComponent<Hand>();
        // Set the controller reference
        controller = _hand.controller;
    }

    void Update()
    {
        // === NULL REFERENCE === //
        if (controller.GetHairTrigger())
        {
            Debug.Log("Trigger");
        }

    }
}

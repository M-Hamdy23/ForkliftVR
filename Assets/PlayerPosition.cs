using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosition : MonoBehaviour {

    public Transform player;
    public Vector3Variable fixingTirePosition;
    public Vector3Variable drivingPoasition;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTireFix()
    {
        player.position = fixingTirePosition.value;
    }
    public void OnDriving()
    {
        player.position = drivingPoasition.value;
    }
}

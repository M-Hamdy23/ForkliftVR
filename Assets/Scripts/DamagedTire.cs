using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagedTire : MonoBehaviour {

    public BoolVariable damagedTire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (damagedTire.value=true)
        {
            //if trigger call bumpTire
        }
	}
    public void BumpTire()
    {
        transform.localScale = new Vector3(1, 1, 1);
        damagedTire.value = false;
    }
    public void FlatTire()
    {
        transform.localScale = new Vector3(1, 1, .15f);
        damagedTire.value = true;
    }
}

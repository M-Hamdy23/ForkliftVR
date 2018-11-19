using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingRotation : MonoBehaviour {
    public Vector3Variable rotationAxis;
    public GameObject rotationWheel;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(rotationWheel.transform.localEulerAngles);
        rotationAxis.value.y=map( rotationWheel.transform.localEulerAngles.y,0,360f,-0.1f,0.1f);
        rotationAxis.value.x = 0;
        rotationAxis.value.z = 0;

    }
    public float map(float value,float sourceMin, float sourceMax , float disMin,float disMax)
    {

        return (value - sourceMin) / (sourceMax - sourceMin) * (disMax - disMin) + disMin;
       
    }
    
}

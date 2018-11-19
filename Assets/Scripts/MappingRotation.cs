using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MappingRotation : MonoBehaviour
{
    public Vector3Variable rotationAxis;
    public GameObject rotationWheel;
    [HideInInspector]
    public bool rotationChanged;

    Vector3 oldRotation;
    public float dir = 1;

    // Use this for initialization
    void Start ()
    {
        rotationAxis.value = Vector3.zero;

        oldRotation.y = (rotationWheel.transform.localEulerAngles.y) / 1000;// map(rotationWheel.transform.localEulerAngles.y, 0, 360f, -0.1f, 0.1f);
        oldRotation.x = 0;
        oldRotation.z = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 tmp = Vector3.zero;

        tmp.y = (rotationWheel.transform.localEulerAngles.y) / 1000;// map(rotationWheel.transform.localEulerAngles.y, 0, 360f, -0.1f, 0.1f);
        tmp.x = 0;
        tmp.z = 0;

        float f = Mathf.Abs(oldRotation.sqrMagnitude - tmp.sqrMagnitude);

        dir = 1;

        //if (oldRotation.y > tmp.y)
        //{
        //    dir = -1;
        //}

        print(tmp.y);

        if (f > 0.000001f)
        {
            rotationAxis.value.y = (rotationWheel.transform.localEulerAngles.y) / 1000;// map(rotationWheel.transform.localEulerAngles.y, -180, 180, -0.1f, 0.1f);
            rotationAxis.value.x = 0;
            rotationAxis.value.z = 0;

            oldRotation = tmp;
            rotationChanged = true;
        }
        else
        {
            rotationChanged = false;
        }
    }

    public float map(float value,float sourceMin, float sourceMax , float disMin,float disMax)
    {
        return (value - sourceMin) / (sourceMax - sourceMin) * (disMax - disMin) + disMin;       
    }    
}

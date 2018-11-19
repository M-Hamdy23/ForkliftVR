using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSetter : MonoBehaviour {

    public Vector3Variable fixingTirePosition;
    public Vector3Variable drivingPoasition;

    public void SetFixingPosition()
    {
        fixingTirePosition.value = transform.position;    
    }
    public void SetDrivingPosition()
    {
        drivingPoasition.value = transform.position;
    }
}

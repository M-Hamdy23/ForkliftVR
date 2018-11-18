using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifting : MonoBehaviour
{
    public float minY;
    public float maxY;
    public FloatVariable liftingStick;
    public Transform blah;
    public float speed;

    float currentHeight;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    private void Move()
    {
        float target = 0;

        if (liftingStick.value == -1)
        {
            target = minY;
        }
        else if (liftingStick.value == 1)
        {
            target = maxY;
        }
        else
        {
            target = blah.localPosition.y;
        }

        currentHeight = Mathf.MoveTowards(blah.localPosition.y, target, speed * Time.deltaTime);

        blah.localPosition = new Vector3(blah.localPosition.x, currentHeight, blah.localPosition.z);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoicesHandler : MonoBehaviour {

    public GameEvent startRiding;
    public GameEvent tireFixing;
    public GameEvent showListItem;

    public GameObject tireButton;
    public GameObject gasButton;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowListEvent()
    {
        showListItem.Raise();
    }

    public void StartRidingEvent()
    {
        startRiding.Raise();
    }

    public void TireFixingEvent()
    {
        tireFixing.Raise();
    }

    public void HideCheckItem()
    {
        tireButton.SetActive(false);
        gasButton.SetActive(false);
    }

    public void ShowCheckItem()
    {
        tireButton.SetActive(true);
        gasButton.SetActive(true);
    }


}

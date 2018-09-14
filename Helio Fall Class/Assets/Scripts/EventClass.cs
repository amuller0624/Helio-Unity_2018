using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventClass : MonoBehaviour {

    public UnityEvent Event;
	// Use this for initialization
	void OnMouseDown () {

        Event.Invoke();
		
	}

    // Update is called once per frame

    void OnTriggerEnter()

    {
        Event.Invoke();
    }
    void Update () {
		
	}
}

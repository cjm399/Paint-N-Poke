using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class MyFirstTouch : MonoBehaviour {

	//Subscribe to events
	void OnEnable(){
		EasyTouch.On_TouchStart += On_TouchStart;
	}

	//Unsubscribe
	void OnDisable(){
		EasyTouch.On_TouchStart -= On_TouchStart;
	}

	void OnDestroy(){
		EasyTouch.On_TouchStart -= On_TouchStart;
	}
	public void On_TouchStart(Gesture gesture){
		Debug.Log ("Touch in " + gesture.position);
	}
}

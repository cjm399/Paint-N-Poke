using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

public class move : MonoBehaviour {
	
    //public
	public GameObject player;
	public float speed = 70;

    //private
    public bool moving = false;
	private Vector3 movePoint, hitPoint;

	void Start(){
		player = GameObject.Find ("Picasso");
	}

	void OnEnable(){
		EasyTouch.On_TouchStart += On_TouchStart;
	}

	void OnDisable(){
		EasyTouch.On_TouchStart -= On_TouchStart;
	}

	void OnDestroy(){
		EasyTouch.On_TouchStart -= On_TouchStart;
	}

	public void On_TouchStart(Gesture gesture){
		hitPoint = new Vector3(gesture.position.x, gesture.position.y, 1f);
		movePoint = this.GetComponent<Camera> ().ScreenToWorldPoint (hitPoint);

		if (movePoint.y > 71f) {
			movePoint.y = 71f;
		}

		moving = true;
	}

	void Update(){

		if (moving) {
			player.transform.position = Vector3.MoveTowards (player.transform.position, movePoint, speed * Time.deltaTime);
		}

		if (movePoint == player.transform.position) {
			moving = false;
		}
	}
}

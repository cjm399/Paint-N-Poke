using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_movement : MonoBehaviour {

	public float speed;
	public GameObject[] enemies_On_Screen;
	public GameObject player;
	private Vector3 targetPos;
	void Start () {
		targetPos = new Vector3 (0f, 0f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
		//*PERFORMANCE* Would it be better to make this only called when the player moves?
		targetPos = player.transform.position;
		transform.position = Vector3.MoveTowards (transform.position, targetPos, speed * Time.deltaTime);
	}

	void OnTriggerEnter2D( Collider2D col ){
		if (col.gameObject.tag.Equals ("Player")) {
			Camera.main.SendMessage ("GameOver");
		}
	}
}

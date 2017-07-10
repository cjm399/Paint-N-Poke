using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* I want this script to do a few things.
 * I want it to spawn enemies
 * I want it to keep score
 * I want it to make the game get harder over time
*/
public class GameController : MonoBehaviour {

	private GameObject player;
	public GameObject[] enemies;
	private GameObject[] enemiesOnScreen;
	private Collider2D collider;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Picasso");

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GameOver(){
		Debug.Log ("GAME OVER");
	}
}

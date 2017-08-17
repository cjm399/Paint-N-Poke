using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* I want this script to do a few things.
 * I want it to spawn enemies
 * I want it to keep score
 * I want it to make the game get harder over time
*/
public class GameController : MonoBehaviour {

	// PUBLIC VARIABLES
	public GameObject[] enemies;

	// PRIVATE VARIABLES
	private GameObject player;
	private GameObject[] enemiesOnScreen;
	private Collider2D collider;


	// Use this for initialization
	void Awake ()
	{
		player = GameObject.Find ("Picasso");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}

	void NewEnemy()
	{
		Instantiate (enemies [0]);
	}

	void GameOver()
	{
		Debug.Log ("GAME OVER");
	}
}

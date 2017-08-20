using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

// This Script does a few things:
// 1. Assigns a target enemy, and if there is no target enemy (nullEnemy) finds an enemy to target.
// 2. Checks what type of enemy the target enemy is
// 3. Checks what colors the user has created, if the created colors match the enemy type the enemy dies.
/* To Do:
 * Fix this so it works with three colored enemies and 4 and 5 and 6...
 * 
*/
public class Button_Handler : MonoBehaviour {

	// PUBLIC VARIABLES
	public GameObject selectedTarget;


	// PRIVATE VARIABLES
	//private GameObject[] enemiesOnScreen;
	private GameController gamecontroller;
	private string enemyType, newEnemyType;
	private int red = 0, blue = 0, yellow = 0, green = 0, orange = 0, purple = 0;
	private GameObject nullEnemy, enAliveObj, player;


	void Awake()
	{
		
		nullEnemy = GameObject.FindGameObjectWithTag ("NE");
		selectedTarget = nullEnemy;
		enemyType = selectedTarget.tag;
		player = GameObject.Find ("Picasso");
	}

	void Start()
	{
		enAliveObj = GameObject.Find ("EnemiesAlive");
	}


	void newEnemy()
	{
		newEnemyType = selectedTarget.tag;
		if (!(newEnemyType == enemyType))
		{
			red = 0;
			blue = 0;
			yellow = 0;
			green = 0;
			orange = 0;
			purple = 0;
			enemyType = newEnemyType;
		}
	}


	void Update()
	{
		// If the player has no target enemy and there are enemies on screen, set it to the enemy that came on screen first.
		if (selectedTarget == nullEnemy)
		{
			if ( enAliveObj.transform.childCount > 0)
			{
				selectedTarget = enAliveObj.transform.GetChild(0).gameObject;
				newEnemy ();
			}
		}
		
	}

	public void AddRed(Gesture gesture)
	{
		red +=1;
		Paint_In("Red");
	}

	public void AddYellow(Gesture gesture)
	{
		yellow +=1;
		Paint_In("Yellow");

	}

	public void AddBlue(Gesture gesture){
		blue +=1;
		Paint_In("Blue");

	}

	public void AddPurple(Gesture gesture){
		purple +=1;
		Paint_In("Purple");

	}

	public void AddOrange(Gesture gesture){
		orange +=1;
		Paint_In("Orange");

	}

	public void AddGreen(Gesture gesture){
		green +=1;
		Paint_In("Green");
	}
		
	void Paint_In(string color){

		if (enemyType.Length == 1) {
			if (enemyType == "R") {
				if (red > 0)
					Kill ();
			} else if (enemyType == "B") {
				if (blue > 0)
					Kill ();
			} else if (enemyType == "Y") {
				if (blue > 0)
					Kill ();
			}
			else if (enemyType == "G") {
				if (blue > 0)
					Kill ();
			}
			else if (enemyType == "P") {
				if (blue > 0)
					Kill ();
			}
			else if (enemyType == "O") {
				if (blue > 0)
					Kill ();
			}
		}

		//Checks enemies with 2 colors
		else if(enemyType.Length == 2) {
			//Checks all enemies with red > 0
			if (enemyType.Substring (0, 0) == "r" && red> 0) {
				if (enemyType == "ry" && yellow> 0) {
					Kill ();
				}
				if (enemyType == "rb" && blue > 0) {
					Kill ();
				}
				if (enemyType == "ro" && orange> 0) {
					Kill ();
				}
				if (enemyType == "rp" && purple> 0) {
					Kill ();
				}
				if (enemyType == "rg" && green> 0) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "b" && blue > 0) {
				if (enemyType == "by" && yellow> 0) {
					Kill ();
				}
				if (enemyType == "bg" && green> 0) {
					Kill ();
				}
				if (enemyType == "rp" && purple> 0) {
					Kill ();
				}
				if (enemyType == "ro" && orange> 0) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "g" && green> 0) {
				if (enemyType == "gy" && yellow> 0) {
					Kill ();
				}
				if (enemyType == "gp" && purple> 0) {
					Kill ();
				}
				if (enemyType == "go" && orange> 0) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "y" && yellow> 0) {
				if (enemyType == "yp" && purple> 0) {
					Kill ();
				}
				if (enemyType == "yo" && orange> 0) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "p" && purple> 0) {
				if (enemyType == "po" && orange> 0) {
					Kill ();
				}
			}
		}

		//Checks enemies with three colors.

	}

	void MixColors()
	{
		//Transform posStart = gesture.startPosition;
		//Transform posEnd = gesture.position;

	}
	void Kill(){
		Debug.Log ("I AM KILLING");
		Destroy(selectedTarget.gameObject);
		selectedTarget = nullEnemy;
		Camera.main.SendMessage ("NewEnemy");
	}
}

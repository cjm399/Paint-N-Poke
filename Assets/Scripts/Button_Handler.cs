using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HedgehogTeam.EasyTouch;

/* To Do:
 * Fix this so it works with three colored enemies and 4 and 5 and 6... This will be shitty
 * 
*/
public class Button_Handler : MonoBehaviour {

	public GameObject selectedTarget;
	private string enemyType, newEnemyType;
	private bool red = false, blue = false, yellow = false, green = false, orange = false, purple = false;

	void Start(){
		enemyType = selectedTarget.tag;
	}

	void Update(){
		newEnemyType = selectedTarget.tag;
		if (newEnemyType == enemyType) {
			enemyType = selectedTarget.tag;
		}
		else
		{
			red = false;
			blue = false;
			yellow = false;
			green = false;
			orange = false;
			purple = false;
		}
	}

	public void AddRed(Gesture gesture){
		red = true;
		Paint_In("Red");

	}

	public void AddYellow(Gesture gesture){
		yellow = true;
		Paint_In("Yellow");

	}

	public void AddBlue(Gesture gesture){
		blue = true;
		Paint_In("Blue");

	}

	public void AddPurple(Gesture gesture){
		purple = true;
		Paint_In("Purple");

	}

	public void AddOrange(Gesture gesture){
		orange = true;
		Paint_In("Orange");

	}

	public void AddGreen(Gesture gesture){
		green = true;
		Paint_In("Green");
	}

	void Paint_In(string color){
		Debug.Log ("I AM PAINTING IN " + color);
		Debug.Log(enemyType.Length);

		if (enemyType.Length == 1) {
			if (enemyType == "R") {
				if (red)
					Kill ();
			} else if (enemyType == "B") {
				if (blue)
					Kill ();
			} else if (enemyType == "Y") {
				if (blue)
					Kill ();
			}
			else if (enemyType == "G") {
				if (blue)
					Kill ();
			}
			else if (enemyType == "P") {
				if (blue)
					Kill ();
			}
			else if (enemyType == "O") {
				if (blue)
					Kill ();
			}
		}

		//Checks enemies with 2 colors
		else if(enemyType.Length == 2) {
			//Checks all enemies with red
			if (enemyType.Substring (0, 0) == "r" && red) {
				if (enemyType == "ry" && yellow) {
					Kill ();
				}
				if (enemyType == "rb" && blue) {
					Kill ();
				}
				if (enemyType == "ro" && orange) {
					Kill ();
				}
				if (enemyType == "rp" && purple) {
					Kill ();
				}
				if (enemyType == "rg" && green) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "b" && blue) {
				if (enemyType == "by" && yellow) {
					Kill ();
				}
				if (enemyType == "bg" && green) {
					Kill ();
				}
				if (enemyType == "rp" && purple) {
					Kill ();
				}
				if (enemyType == "ro" && orange) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "g" && green) {
				if (enemyType == "gy" && yellow) {
					Kill ();
				}
				if (enemyType == "gp" && purple) {
					Kill ();
				}
				if (enemyType == "go" && orange) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "y" && yellow) {
				if (enemyType == "yp" && purple) {
					Kill ();
				}
				if (enemyType == "yo" && orange) {
					Kill ();
				}
			}
			if (enemyType.Substring (0, 0) == "p" && purple) {
				if (enemyType == "po" && orange) {
					Kill ();
				}
			}
		}

		//Checks enemies with three colors.

	}

	void Kill(){
		Destroy(selectedTarget.gameObject);
	}
}

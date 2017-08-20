using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * This script will handle the animations for the Picasso Player
 * */

public class Anim_Picasso : MonoBehaviour
{

    //Public Variables

    //Private Variables
    private Animator anim;
    private GameObject mainCam;
    private move move;
    void Start()
    {
        anim = this.GetComponent<Animator>();
        mainCam = GameObject.Find("Main Camera");
        move = mainCam.GetComponent<move>();
    }

    // Update is called once per frame
    void Update()
    {
		if (move.moving)
        {
            anim.SetInteger("State", 0);
        }
        else
        {
            anim.SetInteger("State", 1);
        }
    }
}

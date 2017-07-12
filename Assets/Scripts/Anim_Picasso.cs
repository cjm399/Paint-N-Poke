using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Animations;

/*
 * This script will handle the animations for the Picasso Player
 * */

public class Anim_Picasso : MonoBehaviour
{

    //Public Variables

    //Private Variables
    private Animator anim;
    private int walkHash = Animator.StringToHash("Walk");
    private bool moving;
    private GameObject mainCam;
    private move move;
    void Start()
    {
        anim = GetComponent<Animator>();
        mainCam = GameObject.Find("Main Camera");
        move = mainCam.GetComponent<move>();

        moving = move.moving;
    }

    // Update is called once per frame
    void Update()
    {
        moving = move.moving;
        if (moving)
        {
            anim.SetInteger("State", 0);
        }
        else
        {
            anim.SetInteger("State", 1);
        }
    }
}

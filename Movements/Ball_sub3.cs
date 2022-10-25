using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_sub3 : MonoBehaviour

{
    public Animator ballAnimator;
    public GameObject ballSub;
    public GameObject playerShield;
    public GameObject playerIdle;
    //public Animator ballBlockVFX;
    public Animator playerAnimator;
    public GameObject BlockFX;
    public GameObject DeadFX;
    void Start()
    {
        // Access to Animator component on start
        ballAnimator = ballSub.GetComponent<Animator>();
        //ballBlockVFX = GetComponent<Animator>();
        playerAnimator = playerIdle.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E) && other.gameObject.tag == "Ball_sub3_true" && playerShield.activeSelf)
        {
            Debug.Log(other.gameObject.name);
            Debug.Log("Collide with shield");
            // ballAnimator.SetBool("Block", true);
            ballSub.SetActive(false);
            BlockFX.SetActive(true);
        }
        else if (other.gameObject.tag == "Ball_sub3_true" && !playerShield.activeSelf)
        {
            print("Colliding Fireeball");
            DeadFX.SetActive(true);
            //ballAnimator.SetBool("Block", false);
            // muerte personaje
        }
        else if (!Input.GetKey(KeyCode.E))
            {
            BlockFX.SetActive(false);           
        }

    }
    //after same sec Object to false
    void LateUpdate()
    {
        if (ballSub.activeInHierarchy == false)
        {
            ballSub.SetActive(true);
            //ballSub.SetActive(true);
        }
    }
}

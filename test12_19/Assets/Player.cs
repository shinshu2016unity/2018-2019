﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Animator animator;
    private Rigidbody rg;
    private bool isGround = true;
    public float RunSpeed;
    public float MaxSpeed;
    public float JumpPower;
    public float ForceGravity = 100f;
    public float RotateSpeed = 2f;
    private float JumpCount = 0;
   


    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator> ();
        rg = this.transform.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
        {
            if (rg.velocity.magnitude < MaxSpeed)
            {
                rg.AddForce(transform.forward * RunSpeed);
            }
            if (isGround)
            {
                animator.SetBool("is_running", true);
            }
        }

        else if (Input.GetKey("down"))
        {
            if (rg.velocity.magnitude < MaxSpeed * 0.2f)
            {
                rg.AddForce(-transform.forward * RunSpeed);
            }
            if (isGround)
            {
                animator.SetBool("is_backing", true);
            }
        }
        else
        {
            if (rg.velocity.magnitude > MaxSpeed * 0.01f)
            {
                rg.AddForce(-rg.velocity * RunSpeed * 0.5f);
            }
            animator.SetBool("is_running", false);
            animator.SetBool("is_backing", false);
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, RotateSpeed, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -RotateSpeed, 0);
        }
        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(transform.up * JumpPower);
            animator.SetBool("is_jumping", true);
            JumpCount += 1;
        }
        if (isGround == false && JumpCount == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            rg.AddForce(transform.up * JumpPower);
            animator.SetBool("is_jumping", true);
            JumpCount = 0;
        }
    }


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            animator.SetBool("is_jumping", false);
            JumpCount = 0;
        }

    }

    void OnCollisionStay(Collision col)
    {
        if(col.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGround = false;
        }

    }
}

		
	

 
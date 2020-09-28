﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ForceMode jumpForceMode;

    // Start is called before the first frame update
    void Start()
    {
        //Sets reference to the RidgidBody on the Player
        rb = GetComponent<Rigidbody>();

        //Modify gravity
        if (Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;

        }
    }

    // Update is called once per frame
    void Update()
    {
        //Press Space bar to jump
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, jumpForceMode);
            isOnGround = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
        }
    }
}

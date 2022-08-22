﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float forwardBackwardSpeed;
    public float upDownSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        forwardBackwardSpeed = rotationSpeed * Time.deltaTime * horizontalInput;
        upDownSpeed = rotationSpeed * Time.deltaTime * verticalInput;

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        transform.Rotate(Vector3.down * forwardBackwardSpeed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.left, upDownSpeed);
    }
}

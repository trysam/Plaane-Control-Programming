using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardBackwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get the user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardBackwardInput = Input.GetAxis("Vertical");

        //We'll move the vehicle forward or backward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardBackwardInput);

        //We'll rotate to the left or right
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
    }
}
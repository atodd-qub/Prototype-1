using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 12.0f;
    private float turnSpeed = 40.0f;
    private float horizontalInput;
    private float forwardInput;
    public string inputID;
    public Camera mainCam;
    public Camera frontCam;
    public KeyCode switchKey;

    // Start is called before the first frame update
    void Start()
    {
        mainCam.enabled = true;
        frontCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        if (Input.GetKeyDown(switchKey))
        {
            mainCam.enabled = !mainCam.enabled;
            frontCam.enabled = !frontCam.enabled;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    private float rotationSpeed = 400.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the Propeller around Z Axis
        transform.Rotate(Vector3.forward, Time.deltaTime * rotationSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OncomingVehicle : MonoBehaviour
{
    private float speed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move vehicle at constant speed
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

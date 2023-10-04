using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour
{
    public Camera mainCam;
    public Camera frontCam;
    
    // Start is called before the first frame update
    void Start()
    {
        mainCam.enabled = true;
        frontCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCam.enabled = !mainCam.enabled;
            frontCam.enabled = !frontCam.enabled;
        }
    }
}

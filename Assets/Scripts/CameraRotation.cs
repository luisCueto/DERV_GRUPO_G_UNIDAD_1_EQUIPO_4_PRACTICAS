using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float velH, velV = 5;
    float yaw, pitch;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += velH * Input.GetAxis("Mouse X");
        pitch -= velV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch,yaw, 0.0f);

    }
}

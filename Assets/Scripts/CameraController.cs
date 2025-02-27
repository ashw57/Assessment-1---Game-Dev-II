using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController: MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;
    public Transform cameraPosition;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= Mathf.Clamp(xRotation, -90f, 90f);

        //Rotate camera and orientation
        transform.rotation = Quaternion.Euler(0, yRotation, 0);

        transform.position = cameraPosition.position;
    }

}

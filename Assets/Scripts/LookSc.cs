using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookSc : MonoBehaviour
{
    //Sets mouse sensitivity
    public float mouseSensitivity = 200f;

    public Transform playerBody;
    float xRotation = 0f;

    // Locks the cursor in the middle of the screen
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Makes the camera rotate, and locks the rotaton on the x axis between straight up and straight down.
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}

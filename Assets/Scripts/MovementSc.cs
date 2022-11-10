using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSc : MonoBehaviour
{
    //Makes the character controller do its thing
    public CharacterController controller;

    //Sets the speed of the player
    public float moveSpeed = 12f;

    // Makes the player move according to the axis of the player
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * moveSpeed * Time.deltaTime);
    }
}

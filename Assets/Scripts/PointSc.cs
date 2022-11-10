using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSc : MonoBehaviour
{
    
    // Makes the point rotate
    void FixedUpdate()
    {

        transform.Rotate(1, 2, 3 * Time.deltaTime);

    }

    //Destroys the point when the player collides with it
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "FPS Player")
        {
            other.GetComponent<CountingSc>().score++;
            Destroy(gameObject);
        }
    }
}

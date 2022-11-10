using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ShadowSc : MonoBehaviour
{
    //Sets who/what the target is
    public Transform target;

    //Calls on the NavMeshAgent
    NavMeshAgent navigation;

    // Makes the NavMesh Agent move in the walkable areas
    void Start()
    {
        navigation = GetComponent<NavMeshAgent>();
    }

    // Sets the position of where the target is in this moment
    void Update()
    {
        navigation.SetDestination(target.position);
    }

    //Makes the shadow win
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "FPS Player")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}

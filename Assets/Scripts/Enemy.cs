using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Navigate to Building
        GameObject building = GameObject.Find("Building");
        if (building)
        {
            GetComponent<NavMeshAgent>().destination = building.transform.position;
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Building")
        {
            other.GetComponentInChildren<HealthBar>().Decrease();
            Destroy(gameObject);
        }
    }
}

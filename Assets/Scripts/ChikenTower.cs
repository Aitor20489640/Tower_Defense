using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikenTower : MonoBehaviour
{
    // The Bullet
    public GameObject bulletPrefab;
    
    // Rotation Speed
    public float rotationSpeed = 35;

    private void Update()
    {
        transform.Rotate(Vector3.up * (Time.deltaTime * rotationSpeed), Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>())
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().target = other.transform;
        }
    }
}

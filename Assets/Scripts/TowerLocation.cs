using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerLocation : MonoBehaviour
{
    public GameObject towerPrefab;

    // Executes when click and unclick the GameObject with the mouse
    private void OnMouseUpAsButton()
    {
        // Build Tower above TowerLocation
        GameObject newTower = Instantiate(towerPrefab);
        newTower.transform.position = transform.position + Vector3.up;
    }
}

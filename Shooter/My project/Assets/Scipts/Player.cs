using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Public variable to assign your prefab
    public GameObject objectToSpawn;

    void Update()
    {
        // Check for left mouse click
        if (Input.GetMouseButtonDown(0))
        {
            SpawnObjectAtMousePosition();
        }
    }

    void SpawnObjectAtMousePosition()
    {
        // Convert mouse position to world position
 
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}
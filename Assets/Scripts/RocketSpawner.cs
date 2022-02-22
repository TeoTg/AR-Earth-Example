using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketSpawner : MonoBehaviour
{
    [SerializeField] 
    [Tooltip("Rocket model.")]
    private GameObject rocket;

    [SerializeField]
    [Tooltip("Spawn transform.")]
    private Transform spawnTransform;
    
    private void OnMouseDown()
    {
        Debug.Log("Click!");
        Instantiate(rocket, spawnTransform);
    }
}

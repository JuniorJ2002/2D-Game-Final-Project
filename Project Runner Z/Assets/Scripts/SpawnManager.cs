using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 2;
    private float spawnInterval = 3f;

    private PlayerController PlayerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnDelay, spawnInterval);
        PlayerControllerScript = GameObject.Find("HeroKnight").GetComponent<PlayerController>();
    }

    // Spawn obstacles
    void SpawnObject()
    {
        // Set random spawn location and random object index
        Vector2 spawnLocation = new Vector2(Random.Range(-10,10), Random.Range(-4, 5));
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!PlayerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }
}



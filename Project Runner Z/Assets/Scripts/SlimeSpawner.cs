using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Unity AI
public class SlimeSpawner : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnDelay = 10f;
    private float spawnInterval = 8f;
    public float chasingInterval = 2f;
    public float chasingDistance = 12f;

    private GameObject HeroKnight;
    private float chasingTimer;

  
    private NavMeshAgent agent; // Unity AI

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
        Vector2 spawnLocation = new Vector2(Random.Range(-10, 10), Random.Range(-4, -4));
        int index = Random.Range(0, objectPrefabs.Length);

        // If game is still active, spawn new object
        if (!PlayerControllerScript.gameOver)
        {
            Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
        }

    }

    private void Update()
    {
        // Chasing Logic.
        chasingTimer -= Time.deltaTime;
        if (chasingTimer <= 0 && Vector2.Distance(transform.position, HeroKnight.transform.position) <= chasingDistance)
        {
            chasingTimer = chasingInterval;
            agent.SetDestination(HeroKnight.transform.position); // Unity AI
        }
    }


}

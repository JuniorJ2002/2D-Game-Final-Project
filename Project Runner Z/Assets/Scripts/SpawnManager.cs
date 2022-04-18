using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnManager : MonoBehaviour
{
    // Variables
    public GameObject coinPrefab;
    public Vector3 spawnPos = new Vector3(25, 0, 0);
    public float startDelay = 2.0f;
    public float repeatRate = 2.0f;
    // Accessing PlayerController
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", startDelay, repeatRate);
        playerController = GameObject.Find("HeroKnight").GetComponent<PlayerController>();
    }
    // Update is called once per frame
    void Update()
    {
    }
    void SpawnObstacle()
    {
        if (playerController.gameOver == false)
            Instantiate(coinPrefab, spawnPos, coinPrefab.transform.rotation);
    }
}


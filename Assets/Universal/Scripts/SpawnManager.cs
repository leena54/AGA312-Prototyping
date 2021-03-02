using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private Vector3 coinSpawn = new Vector3(25, 5, -1);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    public GameObject coin;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
        InvokeRepeating("SpawnCoin", startDelay, repeatRate);

        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void SpawnObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }

    }

    void SpawnCoin()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(coin, coinSpawn, coin.transform.rotation);
        }
    }

    void Update()
    {
        
    }


}

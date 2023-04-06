using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public GameObject player;
    public GameObject cop;
    private float spawnPosX = 7;
    private float spawnPosZ = -30;
    private float spawnPosCopX = 7;
    private float delay = 7;
    private float interval = 1.5f;
    private float copInterval = 3;
    public GameObject road2;
    public GameObject road1;
    private bool onRoad2 = false;
    private bool onRoad1 = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCars", delay, interval);
        InvokeRepeating("SpawnPoliceCars", delay, copInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCars()
    {
        spawnPosX = Random.Range(-7, 7);
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, player.transform.position.z - 10);
        Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
    void SpawnPoliceCars()
    {
        spawnPosCopX = Random.Range(-7, 7);
        Vector3 spawnPosCop = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, player.transform.position.z - 15);
        Instantiate(cop, spawnPosCop, cop.transform.rotation);
    }
}

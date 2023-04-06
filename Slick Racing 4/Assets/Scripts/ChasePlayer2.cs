using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer2 : MonoBehaviour
{
    public GameObject player;
    public GameObject chaseBeacon;
    public GameObject cop;
    public GameObject copSpawn;
    public float interval = 2;
    private float dropDelay = 2;
    public float spawnAtTime = 10f;
    public float speed = 2;
    float dropDistance = 20;
    private float spawnPosX = 7;
    private float spawnPosZ = -30;
    private float spawnPosCopX = 7;

    private Transform copTranform;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPoliceCars", dropDelay, interval);

    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnPoliceCars()
    {
        Vector3 spawnPosCop = copSpawn.transform.position;
        Instantiate(cop);
    }
}

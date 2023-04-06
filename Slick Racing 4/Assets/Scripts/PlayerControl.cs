using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20;
    public float steer;
    public float turnSpeed = 30;
    public float gas;
    private float speedTimer = 0;
    private float timeIncrement = 5;
    public GameObject player;
    private float score;
    public GameObject cop;
    public GameObject garage;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gas = Input.GetAxis("Horizontal");
        steer = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * steer);
        transform.Rotate(Vector3.up, turnSpeed * gas * Time.deltaTime); 

        if (Input.GetKey(KeyCode.W))
        {
            speedTimer += Time.deltaTime;
        }
        else
        {
            speedTimer -= Time.deltaTime;
        }

        if (speedTimer > timeIncrement)
        {
            speed = speed + 10;
            timeIncrement += 5;
        }


        // Score Tracker
        score += 1 * Time.deltaTime;

    }
    private void OnCollisionEnter(Collision collision)
    {   
        if (collision.gameObject.name == "Cop(Clone)")
        {
             Destroy(player);
        }
        if (collision.gameObject.name == "WallLeft")
        {
            Destroy(player);
        }
        if (collision.gameObject.name == "WallRight")
        {
            Destroy(player);
        }
        if (collision.gameObject.name != "garage")
        {
            gas = 0;
            steer = 0;
        }

    }
}

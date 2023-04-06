using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayer : MonoBehaviour
{
    public float speed = 15;
    public float turnSpeed = 50;
    public float gas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gas = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * gas * Time.deltaTime);
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}

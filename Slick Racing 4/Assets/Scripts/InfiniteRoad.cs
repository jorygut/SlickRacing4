using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteRoad : MonoBehaviour
{
    //Game Objects
    public GameObject playerObj;
    public GameObject secondRoad;
    public GameObject road2;
    public GameObject road1;
    //Positions
    public Vector3 startPos;
    private float repeatWidth;
    //Collision Bools
    private bool onRoad2 = false;
    private bool onRoad1 = true;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
        secondRoad = GameObject.Find("Road2");
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Road2" && onRoad2 == false)
        {
            road2.transform.Translate(Vector3.forward * 275);
            onRoad2 = true;
            onRoad1 = false;
        }
        if (collision.gameObject.name == "Road" && onRoad2 == true)
        {
            road1.transform.Translate(Vector3.forward * 275);
            onRoad1 = true;
            onRoad2 = false;
        }
    }
}

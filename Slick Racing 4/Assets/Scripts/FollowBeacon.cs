using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowBeacon : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public GameObject player;

    private Rigidbody copRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        copRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("LevelSelect");
        }
    }
}

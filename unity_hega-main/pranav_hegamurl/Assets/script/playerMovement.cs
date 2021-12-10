using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rigidBodyPlayer;

    public float speed;

    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigidBodyPlayer.AddForce(Vector3.left * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rigidBodyPlayer.AddForce(Vector3.right* speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigidBodyPlayer.AddForce(Vector3.forward * speed * Time.deltaTime, ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidBodyPlayer.AddForce(Vector3.back * speed * Time.deltaTime, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBodyPlayer.AddForce(Vector3.up * jumpForce , ForceMode.Impulse);
        }

    }
}

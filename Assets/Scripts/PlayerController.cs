using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed;
    public float rotationSpeed;
    public float jumpForce;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)){
            
            transform.Translate(0, 0, movementSpeed);
        } 
        if (Input.GetKey(KeyCode.S)){
            
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D)){
            
            transform.Translate(0, movementSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A)){
            
            transform.Translate(0, -movementSpeed, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Force);
        }
    }
}

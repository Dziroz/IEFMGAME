using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float angleSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(0, angleSpeed, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(0, -angleSpeed, 0);
        }
    }
}

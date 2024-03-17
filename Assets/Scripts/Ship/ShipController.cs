using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float boost;
    [SerializeField] private float timer;
    [SerializeField] private float timerSpeed;
    [SerializeField] private float angleSpeed;
    void Start()
    {
        maxSpeed = speed;
        speed = 0;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        timer += Time.deltaTime;
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && timer >= timerSpeed)
        {
            if(speed<= maxSpeed)
            {
                timer = 0;
                speed += boost;
            }
        }
        else if(Input.GetKey(KeyCode.S) && timer >= timerSpeed)       
        {
            if (speed >= -maxSpeed)
            {
                timer = 0;
                speed -= boost;
            }
        }
        else
        {
            if (timer >= timerSpeed)
            {
                if (speed != 0)
                {
                    if (speed > 0)
                    {
                        speed -= boost;
                        timer = 0;
                    }
                    else
                    {
                        speed += boost;
                        timer = 0;
                    }
                }

            }
        }
        Move();
    }
    private void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //rb.AddRelativeForce(speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //rb.AddRelativeForce(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(0, 0, angleSpeed);
            Debug.Log("right");
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(0, 0, -angleSpeed);
            Debug.Log("left");
        }
        rb.AddRelativeForce(speed, 0, 0);
    }
}

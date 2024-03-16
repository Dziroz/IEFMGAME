using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish_Controller : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
    }
    private void FixedUpdate()
    {
        rb.AddRelativeForce(speed, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 1;
    [SerializeField] private Rigidbody rg;
    [SerializeField] private float jumpForce = 300;
    [SerializeField] private float run_sped = 0;
    private float smoothrot = 0.1f;//коэфицент плавной ротации
    float smoothturnvel;//скорость плавной ротации
    void Update()
    {
        run_sped = speed;
        if(Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift)) run_sped = speed*2;
        Vector3 dir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * run_sped;
        dir.y = rg.velocity.y;
        rg.velocity = dir;
        if (Input.GetKeyDown(KeyCode.Space)) rg.AddForce(Vector3.up * jumpForce);
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        float smoothangle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref smoothturnvel, smoothrot);
        transform.rotation = Quaternion.Euler(0f, smoothangle, 0f);
    }
}

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

    [SerializeField] private float smoothrot = 0.05f;//коэфицент плавной ротации
    float smoothturnvel;//скорость плавной ротации

    //public bool isGrounded;

    void Update()
    {
        run_sped = speed;
        float pl_horiz = Input.GetAxis("Horizontal");
        float pl_vert = Input.GetAxis("Vertical");

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        Vector3 Cam_rel_vert = pl_vert * forward;
        Vector3 Cam_rel_horiz = pl_horiz * right;

        Vector3 Cam_rel_movement = Cam_rel_horiz + Cam_rel_vert;

        if (Input.GetKey(KeyCode.LeftShift)|| Input.GetKey(KeyCode.RightShift)) run_sped = speed*2;
        Vector3 dir = Cam_rel_movement * run_sped;

        dir.y = rg.velocity.y;
        rg.velocity = dir;
     
        if (Input.GetKeyDown(KeyCode.Space)) rg.AddForce(Vector3.up * jumpForce);
        

        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        float smoothangle = Mathf.SmoothDampAngle(transform.eulerAngles.y, angle, ref smoothturnvel, smoothrot);
        if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical"))!= 0)
                transform.rotation = Quaternion.Euler(0f, smoothangle, 0f);
    }
    /*void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }*/
}


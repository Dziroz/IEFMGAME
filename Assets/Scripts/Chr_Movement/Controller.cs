using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void Take()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {       
        if(other.gameObject.name == "Box")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.gameObject.GetComponent<Animator>().Play("Open");
            }
        }
    }
}

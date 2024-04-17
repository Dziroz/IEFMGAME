using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] private GameObject Player;
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
        if(other.gameObject.name == "metal")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(other.gameObject);
                //other.gameObject.SetActive(false);
            }
        }
    }
}

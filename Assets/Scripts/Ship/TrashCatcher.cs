using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCatcher : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] Collider col;
    [SerializeField] GameObject fishNet;
    [SerializeField] float power;
    [SerializeField] bool go = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            go = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Trash")
        {
            if (go)
            {
                GameObject x = Instantiate(fishNet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
                x.GetComponent<Rigidbody>().AddRelativeForce((-transform.position + other.transform.position) * power);
                go = false;
            }


            Debug.Log("trash");
        }
    }
}

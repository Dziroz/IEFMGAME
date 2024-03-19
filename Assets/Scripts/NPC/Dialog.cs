using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public bool player_detection = false;
    int i = 0;
    public GameObject butt;
    void Update()
    {
        if (player_detection && Input.GetKeyDown(KeyCode.E))
            {
                print("dialoggg" + i);
                i++;
            }
        }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "suka_blyat_anim") 
        { 
            player_detection = true; 
            butt.SetActive(true); 
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
        butt.SetActive(false);
    }
}

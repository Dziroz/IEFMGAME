using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public bool player_detection = false;
    public int i = 0;
    public GameObject butt;
    public GameObject text;
    void Update()
    {
        if (player_detection && Input.GetKeyDown(KeyCode.E))
            {
            i++;
            text.SetActive(true);
            if (i % 2 == 0) { text.SetActive(false); i = 0; }
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
        text.SetActive(false);
        i = 0;
    }
}

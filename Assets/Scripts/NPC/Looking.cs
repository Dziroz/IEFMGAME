using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    public GameObject player;
    public Dialog Looksmax;

    void Update()
    {
        if (Looksmax.player_detection)
        {
        Vector3 delta = new Vector3(player.transform.position.x - transform.position.x, 0.0f, player.transform.position.z - transform.position.z);
        Quaternion rotation = Quaternion.LookRotation(delta);
        transform.rotation = rotation;
    }
    }

}
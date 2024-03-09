using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    [SerializeField] private GameObject anchorPrefab;
    [SerializeField] private GameObject anchor;
    [SerializeField] private Transform player;


    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (anchor == null)
            {
                anchor = Instantiate(anchorPrefab, new Vector3(player.position.x, player.position.y, player.position.z), Quaternion.identity);
            }
            else
            {
                Destroy(anchor.gameObject);
                anchor = null;
            }
        }
    }
}


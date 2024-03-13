using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSystem : MonoBehaviour
{
    [SerializeField] int scene;
    [SerializeField] GameObject ender;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            StarterEnder.loadedScene = scene;
            ender.SetActive(true);
        }
        
    }
}

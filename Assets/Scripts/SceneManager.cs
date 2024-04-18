using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSystem : MonoBehaviour
{
    [SerializeField] string scene;
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
        Debug.Log(StarterEnder.loadedScene);
        
    }
}

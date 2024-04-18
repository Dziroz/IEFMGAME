using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarterEnder : MonoBehaviour
{
    static public string loadedScene;
    public bool go;
    public bool flag = true;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (go)
        {
            SceneManager.LoadScene(loadedScene);
            go = false;
        }
    }
    public void Load()
    {
        SceneManager.LoadScene(loadedScene);
    }
}

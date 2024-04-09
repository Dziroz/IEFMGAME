using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarterEnder : MonoBehaviour
{
    static public int loadedScene;
    public bool go;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (go)
        {
            Load();
        }
    }
    public void Load()
    {
        SceneManager.LoadScene(loadedScene);
    }
}

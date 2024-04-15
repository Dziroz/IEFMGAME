using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Museum : MonoBehaviour
{
    public GameObject[] artifact;
    public static bool[] selfArtifact;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    void MuseumStart()
    {
        for (int i = 0; i < artifact.Length; i++)
        {
            if (selfArtifact[i] == true) 
            {
                artifact[i].SetActive(true);
            }
            
        }
    }
}

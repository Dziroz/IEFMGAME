using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Museum : MonoBehaviour
{
    [SerializeField]public GameObject[] artifact;
    public static bool[] selfArtifact = new bool[5];
    void Start()
    {
        selfArtifact[0] = true;
        MuseumStart();
    }

 
    void Update()
    {
        Debug.Log(selfArtifact[0]);
      
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

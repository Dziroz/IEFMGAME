using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class WaterManager : MonoBehaviour
{
    private MeshFilter meshFitler;

    private void Awake()
    {
        meshFitler = GetComponent<MeshFilter>();
    }

    private void Update()
    {
        Vector3[] vertices = meshFitler.mesh.vertices;
        for (int i = 0; i < vertices.Length; i++)
        {
            vertices[i].y = WaveManager.instance.GetWaveHeight(transform.position.x + vertices[i].x);
        }

        meshFitler.mesh.vertices = vertices;
        meshFitler.mesh.RecalculateNormals();
    }
}

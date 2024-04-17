using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalDetector : MonoBehaviour
{
    [SerializeField] float detectionRadius;
    [SerializeField] public GameObject[] detectedItem;
    [SerializeField] public GameObject currentItem;
    [SerializeField] float distance;
    [SerializeField] AudioSource audio;
    [SerializeField] float timer;
    [SerializeField] float period;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        //Detection();
    }

    void Update()
    {
        if (currentItem == null)
        {
            Detection();
        }
        timer += Time.deltaTime;
        Indication();
        Tracking();
    }
    void Detection()
    {
        detectedItem = GameObject.FindGameObjectsWithTag("metal");
        currentItem = detectedItem[0];
    }
    void Tracking()
    {
        for (int i = 0; i < detectedItem.Length; i++)
        {
            float x = Vector3.Distance(gameObject.transform.position, detectedItem[i].transform.position);
            if(x <= detectionRadius)
            {
                if(Vector3.Distance(gameObject.transform.position, currentItem.transform.position) > Vector3.Distance(gameObject.transform.position, detectedItem[i].transform.position))
                {
                    currentItem = detectedItem[i];
                }
            }
        }
    }
    void Indication()
    {
        if(Vector3.Distance(gameObject.transform.position, currentItem.transform.position) < detectionRadius)
        {
            distance = Vector3.Distance(gameObject.transform.position, currentItem.transform.position);
            if (timer >= distance/10)
            {
                audio.Play();
                timer = 0;
            }
            Debug.Log(distance);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Talking: MonoBehaviour
{
    [SerializeField] private string text;
    [SerializeField] private string finalText;
    [SerializeField] private float speed;
    [SerializeField] private int charNumber;
    [SerializeField] private float timer;

    [SerializeField] TextMeshProUGUI tmPro;
    void Start()
    {
        
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > speed)
        {
            Texting();
            timer = 0;
        }
    }
    void Texting()
    {      
        finalText = finalText + text[charNumber];
        charNumber++;
        tmPro.text = finalText;
        //Debug.Log(finalText);

    }
}

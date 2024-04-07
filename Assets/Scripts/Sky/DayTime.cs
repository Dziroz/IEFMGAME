using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DayTime: MonoBehaviour
{
    
    [SerializeField] Gradient directionalLightGradient;
    [SerializeField] Gradient ambientLightGradient;

    [SerializeField, Range(1, 3600)] float timeDayInSecond = 60;
    [SerializeField, Range(0f, 1f)] float timeProgress;

    [SerializeField] Light dirLight;

    Vector3 defaultAngless;
    void Start()
    {
        defaultAngless = dirLight.transform.localEulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Application.isPlaying)
        {
            timeProgress += Time.deltaTime / timeDayInSecond;
        }

        if (timeProgress > 1f)
        {
            timeProgress = 0f;
        }

        dirLight.color = directionalLightGradient.Evaluate(timeProgress);
        RenderSettings.ambientLight = ambientLightGradient.Evaluate(timeProgress);

        dirLight.transform.localEulerAngles = new Vector3(360f * timeProgress - 90, defaultAngless.x, defaultAngless.z);
    }
}

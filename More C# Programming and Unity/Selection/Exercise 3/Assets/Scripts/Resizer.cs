using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Resizer : MonoBehaviour
{
    // timer support variables
    const float TotalResizeSeconds = 3;
    float elapsedResizeSeconds = 0;

    // resize support variables
    const float ScaleFactorPerSecond = 1;
    int scaleFactorSignMultiplier = 1;


    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale.x += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        newScale.y += scaleFactorSignMultiplier * ScaleFactorPerSecond * Time.deltaTime;
        transform.localScale = newScale;

        elapsedResizeSeconds += Time.deltaTime;
        if (elapsedResizeSeconds >= TotalResizeSeconds)
        {
            elapsedResizeSeconds = 0;
            scaleFactorSignMultiplier *= -1;

        }
    }
}

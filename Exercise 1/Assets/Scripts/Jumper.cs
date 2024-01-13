using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Jumper : MonoBehaviour
{

    // jump location support
    const float maxX = 4;
    const float maxY = 1.8f;
    const float minX = -4;
    const float minY = -1.8f;
 


    // time support
    const float TotalJumpDelaySeconds = 0.02f;
    float elapsedJumpDelaySeconds = 0;


    // Update is called once per frame
    void Update()
    {
        // update timer and check if it's done
        elapsedJumpDelaySeconds += Time.deltaTime;

        if(elapsedJumpDelaySeconds >= TotalJumpDelaySeconds)
        {
            elapsedJumpDelaySeconds = 0;
            Vector3 position = transform.position;
            position.x = Random.Range(minX, maxX);
            position.y = Random.Range(minY, maxY);
            transform.position = position;
        }
    }
}

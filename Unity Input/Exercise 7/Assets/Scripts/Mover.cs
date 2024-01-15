using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Update is called once per frame

    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");
        const float MovesPerSecond = 5;

        Vector3 position = transform.position;

        if(horizontalMove != 0)
        {
            position.x += horizontalMove * MovesPerSecond * Time.deltaTime;
            transform.position = position;
        }
        if (verticalMove != 0)
        {
            position.y += verticalMove * MovesPerSecond * Time.deltaTime;
            transform.position = position;
        }
    }
}

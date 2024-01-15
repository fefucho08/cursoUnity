using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves the game object
/// </summary>
public class Follower : MonoBehaviour
{
    void Update()
    {
        Vector2 currentVector = gameObject.GetComponent<Rigidbody2D>().GetVector();

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        float deltaX = mousePosition.x - transform.position.x;
        float deltaY = mousePosition.y - transform.position.y;

        Vector2 direction = new Vector2(deltaX, deltaY);

        gameObject.GetComponent<Rigidbody2D>().AddForce(direction * 2.0f, ForceMode2D.Force);

    }

}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField]
    GameObject prefabBullet;

    float deltaX, deltaY;
    bool inputPreviousFrame = false;
    Rigidbody2D rb;
    BoxCollider2D collider;
    float halfColliderWidth, halfColliderHeight;

    const float BulletForce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();

        halfColliderWidth = collider.size.x / 2;
        halfColliderHeight = collider.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        FollowMouse();
        
        if(Input.GetAxis("Shoot") > 0 )
        {
            if (!inputPreviousFrame)
            {
                inputPreviousFrame = true;
                Shoot();
            }
        }
        else
        {
            inputPreviousFrame = false;
        }
    }

    void FollowMouse()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        deltaX = mousePosition.x - transform.position.x;
        deltaY = mousePosition.y - transform.position.y;

        float angle = Mathf.Atan2(deltaY, deltaX) - Mathf.PI/2;
        //transform.Rotate(Vector3.forward, angle * Mathf.Rad2Deg);
        rb.rotation = angle * Mathf.Rad2Deg;
    }

    void Shoot()
    {
        float angle = rb.rotation + (Mathf.PI / 2)*Mathf.Rad2Deg;
        float positionDeltaX = Mathf.Cos(angle * Mathf.Deg2Rad) * halfColliderWidth * 2;
        float positionDeltaY = Mathf.Sin(angle * Mathf.Deg2Rad) * halfColliderHeight * 2;

        Vector3 bulletPosition = new Vector3(transform.position.x + positionDeltaX,
            transform.position.y + positionDeltaY,
            -Camera.main.transform.position.z);


        GameObject bullet = Instantiate<GameObject>(prefabBullet, bulletPosition, Quaternion.identity);

        Vector2 bulletDirection = new Vector2(positionDeltaX, positionDeltaY);
        bullet.GetComponent<Rigidbody2D>().AddForce(bulletDirection * BulletForce, ForceMode2D.Impulse);
    }
}

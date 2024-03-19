using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    // thrust aux
    Rigidbody2D physics;

    Vector2 thurstDirection = new Vector2(0, 1);
    const float ThurstForce = 10;

    // collider aux
    float colliderRadius;

    //rotation aux
    const float RotationPerSecond = 20;

    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody2D>();

        colliderRadius = GetComponent<CircleCollider2D>().radius;
    }

    void FixedUpdate()
    {
        if(Input.GetAxis("Impulse") > 0)
        {
            physics.AddForce(thurstDirection * ThurstForce, ForceMode2D.Force);
        }
        
    }

    void OnBecameInvisible()
    {
        Vector2 position = transform.position;

        if (position.x + colliderRadius < ScreenUtils.ScreenLeft || 
            position.x - colliderRadius > ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }
        if (position.y + colliderRadius < ScreenUtils.ScreenBottom || 
            position.y - colliderRadius > ScreenUtils.ScreenTop)
        {
            position.y *= -1;
        }

        transform.position = position;

    }

    // Update is called once per frame
    void Update()
    {
        float rotationInput = Input.GetAxis("Rotate");
        if (rotationInput != 0)
        {
            float rotationAmount = RotationPerSecond * Time.deltaTime;
            if (rotationInput < 0)
            {
                rotationAmount *= -1;
            }
            transform.Rotate(Vector3.forward, rotationAmount);
        }

        float zRotation = transform.eulerAngles.z * Mathf.Deg2Rad;
        thurstDirection.x = Mathf.Cos(zRotation + Mathf.PI/2);
        thurstDirection.y = Mathf.Sin(zRotation + Mathf.PI / 2);
    }
}

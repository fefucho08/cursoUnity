using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Vector3 position;
    const int MovesPerSecond = 10;
    float halfColliderWidth, halfColliderHeight;

    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
        BoxCollider2D collider = GetComponent<BoxCollider2D>();

        halfColliderWidth = collider.size.x / 2;
        halfColliderHeight = collider.size.y / 2;

    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if(horizontal != 0)
        {
            position.x += horizontal * MovesPerSecond * Time.deltaTime;
        }
        if(vertical != 0)
        {
            position.y += vertical * MovesPerSecond * Time.deltaTime;
        }
        transform.position = position;
        ClampPosition();
    }

    void ClampPosition()
    {
        // CLAMP HORIZONTALLY

        if(position.x + halfColliderWidth > ScreenUtils.ScreenRight)
        {
            position.x = ScreenUtils.ScreenRight - halfColliderWidth;
        }
        else if(position.x - halfColliderWidth < ScreenUtils.ScreenLeft)
        {
            position.x = ScreenUtils.ScreenLeft + halfColliderWidth;
        }

        // CLAMP VERTICALLY

        if(position.y + halfColliderHeight > ScreenUtils.ScreenTop)
        {
            position.y = ScreenUtils.ScreenTop - halfColliderHeight;
        }
        else if(position.y -  halfColliderHeight < ScreenUtils.ScreenBottom)
        {
            position.y = ScreenUtils.ScreenBottom + halfColliderHeight;
        }
    }
}

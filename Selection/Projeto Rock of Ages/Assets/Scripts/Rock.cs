using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<Rigidbody2D>();

        const float MinImpulse = 1.0f;
        const float MaxImpulse = 8.0f;

        float magnitude = Random.Range(MinImpulse, MaxImpulse);
        float angle = Random.Range(0, 2 * Mathf.PI);

        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        gameObject.GetComponent<Rigidbody2D>().AddForce(direction * magnitude, ForceMode2D.Impulse);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}

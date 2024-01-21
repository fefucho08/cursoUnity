using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject shipObject = GameObject.FindGameObjectWithTag("Ship");
        Vector3 shipLocation = shipObject.transform.position;

        Vector3 rockSpawnPostion = transform.position;
        float deltaX = shipLocation.x - rockSpawnPostion.x;
        float deltaY = shipLocation.y - rockSpawnPostion.y;

        Vector2 forceDirection = new Vector2(deltaX, deltaY);
        forceDirection.Normalize();

        float forceMagnitude = Random.Range(5f, 10f);

        gameObject.GetComponent<Rigidbody2D>().AddForce(forceDirection * forceMagnitude, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ship")
        {
            FindObjectOfType<RockSpawner>().Spawning = false;
            FindObjectOfType<GameManager>().EndGame();
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
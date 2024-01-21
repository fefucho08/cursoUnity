using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject prefabRock;

    // spawn timer support
    static Timer spawnTimer;
    const float MinSpawnTime = 1;
    const float MaxSpawnTime = 3;
    bool spawning = true;

    // spawn coordinates support
    const float minX = -11f;
    const float maxX = 11f;
    const float minY = -5.5f;
    const float maxY = 5.5f;

    // collision-free spawn support
    const int MaxTries = 20;
    float rockCollisionRadius;
    Vector2 min = new Vector2();
    Vector2 max = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = Random.Range(MinSpawnTime, MaxSpawnTime);
        spawnTimer.Run();

        GameObject tempRock = Instantiate<GameObject>(
            prefabRock, Vector3.zero, Quaternion.identity);
        rockCollisionRadius = tempRock.GetComponent<CircleCollider2D>().radius;
        Destroy(tempRock);
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished && spawning)
        {
            SpawnRock();

            spawnTimer.Duration = Random.Range(MinSpawnTime, MaxSpawnTime);
            spawnTimer.Run();

        }
    }

    void SpawnRock()
    {
        int spawnTries = 0;
        int spawnEdge = Random.Range(0, 4);
        Vector3 location = new Vector3();

        switch(spawnEdge)
        {
            case 0: // TOP
                location.y = maxY;
                location.x = Random.Range(minX, maxX);

                while (IsColliding(location) &&
                    spawnTries < MaxTries)
                {
                    location.x = Random.Range(minX, maxX);
                    spawnTries++;
                }

                break;

            case 1: // RIGHT
                location.x = maxX;
                location.y = Random.Range(minY, maxY);

                while (IsColliding(location) &&
                    spawnTries < MaxTries)
                {
                    location.y = Random.Range(minX, maxX);
                    spawnTries++;
                }
                break;

            case 2: // BOTTOM
                location.y = minY;
                location.x = Random.Range(minX, maxX);

                while (IsColliding(location) &&
                    spawnTries < MaxTries)
                {
                    location.x = Random.Range(minX, maxX);
                    spawnTries++;
                }

                break;

            case 3: // LEFT
                location.x = minX;
                location.y = Random.Range(minY, maxY);

                while (IsColliding(location) &&
                    spawnTries < MaxTries)
                {
                    location.y = Random.Range(minX, maxX);
                    spawnTries++;
                }
                break;
        }

        location.z = -Camera.main.transform.position.z;

        Instantiate<GameObject>(prefabRock,
            location, Quaternion.identity);
    }

    bool IsColliding(Vector3 location)
    {
        SetMinAndMax(location);

        if(Physics2D.OverlapArea(min, max) == null )
        {
            return false;
        }
        else
            return true;
    }
    void SetMinAndMax(Vector3 location)
    {
        min.x = location.x - rockCollisionRadius;
        min.y = location.y - rockCollisionRadius;
        max.x = location.x + rockCollisionRadius;
        max.y = location.y + rockCollisionRadius;
    }

    public bool Spawning
    {
        set
        {
            spawning = value;
        }
    }
}

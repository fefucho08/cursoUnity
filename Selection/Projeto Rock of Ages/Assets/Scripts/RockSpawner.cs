using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    Timer spawnTimer;

    [SerializeField]
    GameObject rockObjectGreen;

    [SerializeField]
    GameObject rockObjectMagenta;

    [SerializeField]
    GameObject rockObjectWhite;

    const int SpawnBorderSize = 100;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    // Start is called before the first frame update
    void Start()
    {
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

        spawnTimer = gameObject.AddComponent<Timer>();
        spawnTimer.Duration = 1;
        spawnTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        int numberOfRocks = GameObject.FindGameObjectsWithTag("Rock").Length;

        if(spawnTimer.Finished && (numberOfRocks < 3))
        {
            SpawnRock();

            spawnTimer.Run();
        }
    }

    void SpawnRock()
    {
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);

        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);

        int randomRock = Random.Range(0, 3);
        GameObject rock;

        switch(randomRock)
        {
            case 0:
                rock = Instantiate(rockObjectGreen) as GameObject;
                break;
            case 1:
                rock = Instantiate(rockObjectWhite) as GameObject;
                break;
            default:
                rock = Instantiate(rockObjectMagenta) as GameObject;
                break;
        }

        rock.transform.position = worldLocation;
    }
}

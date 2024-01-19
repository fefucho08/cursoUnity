using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{

    [SerializeField]
    GameObject prefabRock;

    const float minX = -11f;
    const float maxX = 11f;
    const float minY = -5.5f;
    const float maxY = 5.5f;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX),
                Random.Range(minY, maxY),
                -Camera.main.transform.position.z);

            Instantiate<GameObject>(prefabRock, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

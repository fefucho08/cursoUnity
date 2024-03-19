using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Processes mouse button inputs
/// </summary>
public class MouseButtonProcessor : MonoBehaviour
{
    [SerializeField]
    GameObject prefabExplosion;
    [SerializeField]
    GameObject prefabTeddyBear;

    // first frame input support
    bool spawnInputOnPreviousFrame = false;
	bool explodeInputOnPreviousFrame = false;

	/// <summary>
	/// Update is called once per frame
	/// </summary>
	void Update()
	{
        // spawn teddy bear as appropriate
        if(Input.GetAxis("SpawnTeddyBear") > 0)
        {
            if (!spawnInputOnPreviousFrame)
            {
                spawnInputOnPreviousFrame = true;
                GameObject teddyBear = Instantiate<GameObject>(prefabTeddyBear);

                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = -Camera.main.transform.position.z;

                teddyBear.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
            }
        }
        else
        {
            spawnInputOnPreviousFrame = false;
        }

        // explode teddy bear as appropriate
		if(Input.GetAxis("ExplodeTeddyBear") > 0)
        {
            if (!explodeInputOnPreviousFrame)
            {
                explodeInputOnPreviousFrame = true;

                GameObject explodedTeddy = GameObject.FindWithTag("TeddyBear");

                if(explodedTeddy != null)
                {
                    GameObject explosion = Instantiate<GameObject>(prefabExplosion);

                    explosion.transform.position = explodedTeddy.transform.position;
                    Destroy(explodedTeddy);
                }
                
            }
        }
        else
        {
            explodeInputOnPreviousFrame = false;
        }
	}
}

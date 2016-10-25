using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour
{

    public GameObject wallPrefab;

	// Use this for initialization
	void Start () {
	    InvokeRepeating("SpawnWall", 1f, 3f);
	}

    private void SpawnWall()
    {
        Instantiate(wallPrefab, transform.position, Quaternion.identity);
    }
}

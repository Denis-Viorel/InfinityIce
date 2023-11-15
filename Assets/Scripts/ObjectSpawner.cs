using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject[] trianglePrefabs;
    private Vector3 spawnObjectPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToHorizon = Vector3.Distance(player.gameObject.transform.position, spawnObjectPosition);
        if(distanceToHorizon < 200 ) 
        {
            SpawnTriangles();
        }
    }

    void SpawnTriangles()
    {
        spawnObjectPosition = new Vector3(0, 0, spawnObjectPosition.z + 30);
        Instantiate(trianglePrefabs[(Random.Range(0,trianglePrefabs.Length))], spawnObjectPosition, Quaternion.identity);
    }
}

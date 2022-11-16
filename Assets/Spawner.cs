using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject[] resourcesPrefav;
    public Transform[] SpawnPoints;
    public float spawnTime;
    public float spawnDelay;

    private void Start()
    {
        InvokeRepeating("digx", spawnTime, spawnDelay);
    }

    public void digx()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);
        int randomMin = Random.Range(0, resourcesPrefav.Length);

        Instantiate(resourcesPrefav[randomMin], SpawnPoints[randomIndex].position, Quaternion.identity);
    }


}

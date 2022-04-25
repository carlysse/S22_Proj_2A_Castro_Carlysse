using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float spawnDelay = .3f;
    float nextTimeToSpawn = 0f;

    public GameObject enemy; 

    public Transform[] spawnPoints; 

    void Update () 
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnEnemy(); 
            nextTimeToSpawn = Time.time + spawnDelay; 
        }
    }

    void SpawnEnemy() 
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); 
        Transform spawnPoint = spawnPoints[randomIndex]; 

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
    }

}

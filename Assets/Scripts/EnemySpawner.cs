using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public Transform[] spawnPoints; 

    public float countdownTimer = 2f; 
    void Update ()
    {
        
        if (countdownTimer <= 0f) {
            spawnEnemy(); 
            countdownTimer = 2f;
        }
        else {
            countdownTimer -= Time.deltaTime;
        } 
  
    }
    

    void spawnEnemy() 
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); 
        Transform spawnPoint = spawnPoints[randomIndex]; 

        Instantiate(enemy, spawnPoint.position, spawnPoint.rotation); 
    }


}

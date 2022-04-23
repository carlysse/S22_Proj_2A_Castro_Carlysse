using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

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
        Instantiate(enemy); 
    }


}

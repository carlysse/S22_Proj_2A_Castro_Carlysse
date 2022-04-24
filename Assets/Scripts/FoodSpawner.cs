using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject food; 

    public Transform[] spawnPoints; 

    void Start()
    {
        spawnFood(); 
    }

    void spawnFood() 
    {
        int randomIndex = Random.Range(0, spawnPoints.Length); 
        Transform spawnPoint = spawnPoints[randomIndex]; 

        Instantiate(food, spawnPoint.position, spawnPoint.rotation); 
    }

}

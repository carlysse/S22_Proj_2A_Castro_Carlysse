using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public GameObject food; 
    void OnTriggerEnter2D() {
        Debug.Log("Food obtained!"); 
        //Score.currentScore += 1; 
        SelfDestruct(); 
    }

    void SelfDestruct() 
    {
        Destroy(food); 
    }

}

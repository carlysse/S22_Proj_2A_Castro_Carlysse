using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

    public GameObject food; 
    private SpriteRenderer spriteRenderer; 

    void Start() 
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        if (CustomScene_UI.breadType == 0) {
            Debug.Log("New color set, yellow!"); 
            spriteRenderer.color = new Color32(255, 248, 162, 255);
        } else if (CustomScene_UI.breadType == 1) {
            Debug.Log("New color set, brown!"); 
            spriteRenderer.color = new Color32(144, 105, 51, 255);
        } else if (CustomScene_UI.breadType == 2) {
            Debug.Log("New color set, pink!");
            spriteRenderer.color = new Color32(255, 165, 204, 255);
        }
    }
    void OnTriggerEnter2D() {
        Debug.Log("Food obtained!"); 
        Score.currentScore += 1; 
        SelfDestruct(); 
    }

    void SelfDestruct() 
    {
        Destroy(food); 
    }

}

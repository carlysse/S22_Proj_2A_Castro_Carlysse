using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class Score : MonoBehaviour
{
    public static int currentScore = 0; 
    public int goal = 10; 

    public Text scoreText; 
    void Start ()
    {
        scoreText.text = currentScore.ToString(); 
        if (currentScore >= goal) 
        {
            SceneManager.LoadScene("WinScene");
        }

    }


}

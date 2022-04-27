using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win_UI : MonoBehaviour
{
    public Text winText; 

    void Start(){
        winText.text = CustomScene_UI.playerName + " is full of bread! :D";
    }
}

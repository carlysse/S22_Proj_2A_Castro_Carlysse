using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win_UI : MonoBehaviour
{
    public Text winText; 
    public Button button_Menu;
    public Button button_Quit;

    void Awake() 
    {
        Destroy(GameObject.Find("AudioSource-Easy"));
        Destroy(GameObject.Find("AudioSource-Medium")); 
        Destroy(GameObject.Find("AudioSource-Hard")); 
    }

    void Start(){
        winText.text = CustomScene_UI.playerName + " is full of bread!";
    }

    public void LoadMenu() 
    {
        Debug.Log("Loading menu.."); 
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }
}

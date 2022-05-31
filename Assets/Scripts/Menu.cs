using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    
    public void LoadCustomScene() 
    {
        SceneManager.LoadScene("CustomScene");
    }

    public void LoadHelpScene()
    {
        SceneManager.LoadScene("HelpScene"); 
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }




}

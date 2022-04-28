using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class HelpScene_UI : MonoBehaviour
{
    public Button b_home; 

    public void LoadMenu() {
        SceneManager.LoadScene("MainMenu"); 
    }
}

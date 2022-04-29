using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomScene_UI : MonoBehaviour
{
   public Dropdown dropdown_Bread;
   public Dropdown dropdown_Level; 

   public Button button_Menu;

   public Text txt_LevelInfo; 
   public static int breadType; 

   public InputField inputField; 
   public static string playerName; 
   string sceneToLoad; 


   void Start() {
       breadType = 0; 
       Score.currentScore = 0; 
       sceneToLoad = "Game";
       txt_LevelInfo.text = "Collect 10 loaves of bread to win!";
       playerName = "Player";
   }


   public void DropdownInputData_BreadType()
   {
    if (dropdown_Bread.value == 0) 
    {
        Debug.Log("bread type is 0"); 
        breadType = 0; // Banana, yellow sprite
    }
    else if (dropdown_Bread.value == 1) {
        Debug.Log("bread type is 1");
        breadType = 1; // Chocolate, brown sprite
    }
    else if (dropdown_Bread.value == 2) {
        Debug.Log("bread type is 2");
        breadType = 2; // Strawberry, pink sprite 
    }
   }

    public void DropdownInputData_Level()
    {
        if(dropdown_Level.value == 0) {
            sceneToLoad = "Game";
            txt_LevelInfo.text = "Collect 10 loaves of bread to win!"; 
        }
        else if (dropdown_Level.value == 1) {
            sceneToLoad = "Game_Advanced"; 
            txt_LevelInfo.text = "Collect 20 loaves of bread to win!";
        }
        else if (dropdown_Level.value == 2) {
            sceneToLoad = "Game_Expert"; 
            txt_LevelInfo.text = "Collect 30 loaves of bread to win!";
        }
    }


    public void StartButton_LoadLevel()
    { 
        playerName = inputField.text; 
        SceneManager.LoadScene(sceneToLoad); 

    }

     public void LoadMenu() {
        SceneManager.LoadScene("MainMenu"); 
    }


}

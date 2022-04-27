using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomScene_UI : MonoBehaviour
{
   public Dropdown dropdown_Bread;
   public Dropdown dropdown_Level; 

   public Text txt_LevelInfo; 
   public static int breadType; 

   public InputField inputField; 
   public static string playerName; 
   string sceneToLoad; 


   void Start() {
       breadType = 0; 
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
            txt_LevelInfo.text = "Collect 25 loaves of bread to win!";
        }
        else if (dropdown_Level.value == 2) {
            sceneToLoad = "Game_Expert"; 
            txt_LevelInfo.text = "Collect 30 loaves of bread to win!";
        }
    }


    public void StartButton_LoadLevel()
    { 
        SceneManager.LoadScene(sceneToLoad); 

    }

    public void StoreName() 
    {
        playerName = inputField.GetComponent<Text>().text; 
    }





/*   void Start()
   {
       CustomUIReferences(); 

   }

    private void CustomUIReferences()
   {
       selectedBreadTxt = GameObject.Find("selectedBreadTxt").GetComponent<Text>(); 
       dropdwn_Bread = GameObject.Find("dropdown_Bread").GetComponent<DropDown>(); 
       dropdown_Bread.onValueChanged.AddListener(delegate {CallBack_Dropdown_SetBread(dropdown_Bread); });
       selectedBreadTxt.text = dropdown_Bread.options[dropdown_Bread.value].text;



   }

    void CallBack_Dropdown_SetBread(Dropdown setBread) 
    {
        selectedBreadTxt.text = dropdown_Bread.options[dropdown_Bread.value].text;
    }
*/
}

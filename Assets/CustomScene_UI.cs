using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CustomScene_UI : MonoBehaviour
{
   public Dropdown dropdown_Bread;
   public Dropdown dropdown_Level; 
   public static int breadType ; 
   string sceneToLoad; 

   void Start() {
       breadType = 0; 
       sceneToLoad = "Game"; 
   }

   public void DropdownInputData_BreadType()
   {
    if (dropdown_Bread.value == 0) 
    {
        breadType = 0; // Banana, yellow sprite
    }
    else if (dropdown_Bread.value == 1) {
        breadType = 1; // Chocolate, brown sprite
    }
    else if (dropdown_Bread.value == 2) {
        breadType = 2; // Strawberry, pink sprite 
    }
   }

    public void DropdownInputData_Level()
    {
        if(dropdown_Level.value == 0) {
            sceneToLoad = "Game"; 
        }
        else if (dropdown_Level.value == 1) {
            sceneToLoad = "Game_Advanced"; 
        }
        else if (dropdown_Level.value == 2) {
            sceneToLoad = "Game_Expert"; 
        }
    }

    public void StartButton_LoadLevel() 
    {
        SceneManager.LoadScene(sceneToLoad); 

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

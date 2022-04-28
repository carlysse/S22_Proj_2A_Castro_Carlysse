using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicManager : MonoBehaviour
{
    private static MenuMusicManager musicManagerInstance; 

    void Awake() 
    {
        Destroy(GameObject.Find("AudioSource-Easy"));
        Destroy(GameObject.Find("AudioSource-Medium"));
        Destroy(GameObject.Find("AudioSource-Hard"));


        DontDestroyOnLoad(this); 

        if(musicManagerInstance == null) 
        {
            musicManagerInstance = this; 
        }
        else {
            Destroy(gameObject); 
        }
    }
}

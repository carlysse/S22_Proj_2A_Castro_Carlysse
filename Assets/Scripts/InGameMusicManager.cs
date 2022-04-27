using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMusicManager : MonoBehaviour
{
    private static InGameMusicManager musicManagerInstance; 

    void Awake() 
    {
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

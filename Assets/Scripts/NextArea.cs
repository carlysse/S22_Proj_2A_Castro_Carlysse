using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextArea : MonoBehaviour
{
    void OnTriggerEnter2D() {
        Debug.Log("Moving to next area!"); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

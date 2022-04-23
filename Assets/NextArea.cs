using UnityEngine;
using UnityEngine.SceneManagement; 

public class NextArea : MonoBehaviour
{
    void OnTriggerEnter2D() {
        Debug.Log("Moving to next area!"); 
        Score.currentScore += 1; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}

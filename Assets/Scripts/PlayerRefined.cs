using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlayerRefined : MonoBehaviour
{
  public float moveSpeed = 5f; 
  public Rigidbody2D rb; 
  public Animator animator; 
  
  Vector2 movement; 


  void Update () 
  {
      // Input
      movement.x = Input.GetAxisRaw("Horizontal"); 
      movement.y = Input.GetAxisRaw("Vertical"); 
      
      animator.SetFloat("Horizontal", movement.x); 
      animator.SetFloat("Vertical", movement.y); 
      animator.SetFloat("Speed", movement.sqrMagnitude); 

      transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f),
            Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z);
  }

  void FixedUpdate() 
  {
      // Movement
      rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime); 
  }

  void OnTriggerEnter2D (Collider2D col) 
    {
        if (col.CompareTag("Enemy"))
        {
            Debug.Log("WE LOST!"); 
            Score.currentScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}

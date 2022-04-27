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

  private AudioClip collectSound; 
  private AudioClip deathSound;
  private AudioClip nextAreaSound; 
  private AudioSource audioSource; 
  int expectedScore = Score.currentScore + 1; 

  void Awake() 
  {
      Debug.Log("Scene loaded: " + SceneManager.GetActiveScene().name); 
      audioSource = GetComponent<AudioSource>(); 
  }

  void Start() {
      collectSound = (AudioClip)Resources.Load("collectSound"); 
      deathSound = (AudioClip)Resources.Load("deathSound"); 
      nextAreaSound = (AudioClip)Resources.Load("nextAreaSound"); 
      
  }

  void Update () 
  {
      // Input
      movement.x = Input.GetAxisRaw("Horizontal"); 
      movement.y = Input.GetAxisRaw("Vertical"); 
      
      animator.SetFloat("Horizontal", movement.x); 
      animator.SetFloat("Vertical", movement.y); 
      animator.SetFloat("Speed", movement.sqrMagnitude); 

      transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f),
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
            StartCoroutine(PlayDeathSound());
        }

        if(col.CompareTag("Food"))
        {
            audioSource.clip = collectSound; 
            audioSource.Play(); 
        }

        if(col.CompareTag("NextArea"))
        {
            StartCoroutine(PlayNextAreaSound()); 
        }
    }

    IEnumerator PlayDeathSound() 
    {
        audioSource.clip = deathSound;
        audioSource.Play(); 
        yield return new WaitUntil(() => audioSource.isPlaying == false); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    IEnumerator PlayNextAreaSound() 
    {
        Debug.Log("Current Score: " + Score.currentScore + "  Expected Score: " + expectedScore );
        if (Score.currentScore == expectedScore) {
            audioSource.clip = nextAreaSound; 
            audioSource.Play(); 
            yield return new WaitUntil(() => audioSource.isPlaying == false); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    
    }
}

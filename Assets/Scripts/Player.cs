using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        // moves player with arrow keys
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            rb.MovePosition(rb.position + Vector2.right); 
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            rb.MovePosition(rb.position + Vector2.left); 
        else if (Input.GetKeyDown(KeyCode.UpArrow)) 
            rb.MovePosition(rb.position + Vector2.up);
        else if (Input.GetKeyDown(KeyCode.DownArrow)) 
            rb.MovePosition(rb.position + Vector2.down);

        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5f, 5f),
            Mathf.Clamp(transform.position.y, -5f, 5f), transform.position.z); 

    }
}

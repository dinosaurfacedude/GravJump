using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformer : MonoBehaviour
{
    
    //variables
    public float speed;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public float jumpForce;
    public LayerMask groundLayer;
    public Vector3 respawnPoint;
    Rigidbody2D rb;


    //makes sure player doesn't fall through blocks
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //1 * -1 = -1, and -1 * -1 = 1. Makes sure gravity reverses everytime space is hit.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
        }
    }

    //moves left and right.
    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);

    }

    //Checks if player is falling or dying.
    void onTriggerEnter2d(Collider2D other)
    {
        //If the game object is a falldetector, reset at checkpoint.
        if (other.tag == "FallDetector")
        {

        }
    }


}


    


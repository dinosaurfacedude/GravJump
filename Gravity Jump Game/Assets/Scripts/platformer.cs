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
    public GameObject spawnee;
    public Transform spawnPos;
    private bool lastWentRight = true;
    public static platformer Instance;
    //makes sure player doesn't fall through blocks
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        //1 * -1 = -1, and -1 * -1 = 1. Makes sure gravity reverses everytime space is hit.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.gravityScale *= -1;
            //float newSpawnPos = spawnPos.position + spawnee.scale.x + spawnPos.scale.x;
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(0);
        }
    }

    //moves left and right.
    void Move()
    {

        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        if (lastWentRight && (x<0))
        {
            lastWentRight = false;
        }else if(!lastWentRight && (x > 0))
        {
            lastWentRight = true;
        }


    }

    //Checks if player is falling or dying.
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "FallDetector" || other.tag == "Enemy")
        {
            transform.position = respawnPoint;
        }   
        
        if(other.tag == "checkPoint")
        {
            respawnPoint = other.transform.position;
        }
    }

    public bool isLastWentRight()
    {
        return lastWentRight;
    }
}


    


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Behavior : MonoBehaviour
{
    private float movementDistance = 3;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
       
    }


    void move()
    {
        timer += Time.deltaTime;

        if (timer % movementDistance < (movementDistance / 2))
        {
            transform.Translate(Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-Time.deltaTime, 0, 0);
        }
    }

    void destroyEnemy()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {

            destroyEnemy();
            Destroy(other);
        }

        if(other.tag == "FallDetector")
        {
            destroyEnemy();
        }
    }



}

﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{

    public GameObject enemy;
    public float lifeTime = 1f;
    public Camera mainCamera;
    public Vector2 widthThresold;
    public Vector2 heightThresold;
    public float bulletSpeed;
    int direction;
    // Start is called before the first frame update
    void Start()
    {
        //mainCamera = GameObject.Find("mainCamera").GetComponent<Camera>();
         direction = checkPlatformerDirection();
    }

    // Update is called once per frame
    void Update()
    {
        //time out for the bullet
        if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if (lifeTime <= 0)
            {
                DestroyBullet();
            }

        }/*
        Vector2 screenPosition = mainCamera.WorldToScreenPoint(transform.position);
        if (screenPosition.x < widthThresold.x || screenPosition.x > widthThresold.y 
            || screenPosition.y < heightThresold.x || screenPosition.y > heightThresold.y) 
        {
            DestroyBullet();
        }*/
        Move();
    }
    //Despawns the bullet instance
    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

    private int checkPlatformerDirection()
    {
        if (platformer.Instance.isLastWentRight())
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("Bullet hit: " + other.tag);
        if (other.tag == "Enemy" || other.tag=="goodGuy") 
        {
            DestroyBullet();
            Destroy(other.gameObject);
        }else if(other.tag != "Player")
        {
            //print("OBS or FD");
            DestroyBullet();
        }
    }
   //// void OnCollisionEnter2D(Collision2D col)
    //{
       // Debug.Log("Bullet Collision with: " + col.gameObject.tag);
    //}
    //Moves the Bullet
    //TODO: Direction of player
    void Move()
    {
        transform.Translate(direction*Time.deltaTime*bulletSpeed, 0, 0);
    }

}

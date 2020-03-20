using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior : MonoBehaviour
{
   // public GameObject spawnee;
   // public Transform spawnPos;
    public GameObject enemy;
    public float lifeTime = 10f;
    public Camera mainCamera;
    public Vector2 widthThresold;
    public Vector2 heightThresold;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.Find("mainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
            
        }*/
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

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }

    void OnCollisionEnter(Collision coll)
    {
        DestroyBullet();
    }
    void Move()
    {
        transform.Translate(Time.deltaTime*bulletSpeed, 0, 0);
    }

}

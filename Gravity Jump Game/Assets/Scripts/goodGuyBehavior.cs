﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goodGuyBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void destroyGoodGuy()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
  
        if (other.tag == "Bullet")
        {
            destroyGoodGuy();
            platformer.Instance.transform.position = platformer.Instance.respawnPoint;

        }

        if (other.tag == "FallDetector")
        {
            destroyGoodGuy();
        }
    }



}
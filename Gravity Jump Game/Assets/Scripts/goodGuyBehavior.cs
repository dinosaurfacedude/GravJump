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
 

    private void OnTriggerEnter2D(Collider2D other)
    {
        //print("Good Guy hit: " + other.tag);
        if (other.tag == "Bullet")
        {
            
            platformer.Instance.transform.position = platformer.Instance.respawnPoint;

        }


    }



}

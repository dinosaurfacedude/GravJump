using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstructionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("OnCollisionEnter2D");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.tag);
    }





    }

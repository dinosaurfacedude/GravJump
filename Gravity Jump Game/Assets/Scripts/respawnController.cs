using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnController : MonoBehaviour
{

    public Sprite redFlag;
    public Sprite greenFlag;
    private SpriteRenderer rend;
    public bool checkpointReached;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //checks to see if player reached flag checkpoint
    private void OnTriggerEnter2D(Collider2D other)
    {
      if(other.tag == "Player")
        {
            rend.sprite = greenFlag;
            checkpointReached = true;
        }  
    }
}

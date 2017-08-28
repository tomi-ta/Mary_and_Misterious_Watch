﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crab_enemy : MonoBehaviour {

    Rigidbody2D rb2d;
    private int moveSpeed = -1;

    // Use this for initialization
    void Start () { 

        rb2d = GetComponent<Rigidbody2D>();
       }
	
	// Update is called once per frame
	void Update () {

        rb2d.velocity = new Vector2(transform.localScale.x*moveSpeed, rb2d.velocity.y);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(coll.gameObject);
        }

        if (coll.gameOject.tag == "move box") 
        {
            Vector2 temp = gameObject.transform.localScale;
            temp.x = 1;
            gameObject.transform.localScale = temp;
        }
    }
}

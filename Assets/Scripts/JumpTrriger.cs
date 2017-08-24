using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrriger : PlayerBehaviour {


    List<string> jump_trrige_tag;
    bool jump = false;

    // Use this for initialization
    void Start () {
        jump_trrige_tag = Jump_tag;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        foreach (string n in jump_trrige_tag)
        {
            if (other.gameObject.CompareTag(n))
            {
                jump = false;
            }
        }
    }
}

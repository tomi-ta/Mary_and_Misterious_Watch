using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxBehaviour : PlayerBehaviour {

    private Rigidbody2D boxrb;
    [SerializeField]
    private float bairitu = 1f;
    private bool boxcollision = false;

    // Use this for initialization
    void Start () {
        boxrb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

            boxrb.AddForce(transform.forward * bairitu, ForceMode2D.Impulse);
            boxcollision = false;

    }

}

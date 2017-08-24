using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveliftBehaviour : MonoBehaviour {

    private Vector2 initialPosition;
    [SerializeField]
    private float range =3f;

    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {  
        transform.position = new Vector2(initialPosition.x, Mathf.Cos(Time.time * 1.3f) * range + initialPosition.y);

    }
}

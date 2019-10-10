using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    public float speed = 10.0f;
    public float boundY = 2.25f; //Highest position my paddle can go
    private Rigidbody2D rb2d; //Representation of my RigidyBody2D

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
        var vel = rb2d.velocity;

        if (Input.GetKey(moveUp)) //Go up
        {
            vel.y = speed;
        }
        else if (Input.GetKey(moveDown))// Go down
        {
            vel.y = -speed;
        }
        else //Stay in place
        {
            vel.y = 0;
        }
        rb2d.velocity = vel;

        var pos = transform.position; //My paddle position

        if(pos.y > boundY) //if position bigger than boundY, it will receive the boundY value
        {
            pos.y = boundY;
        }
        else if(pos.y < -boundY) //if position lower than boundY, it will receive the boundY value
        {
            pos.y = -boundY;
        }
        transform.position = pos;
    }

    
}

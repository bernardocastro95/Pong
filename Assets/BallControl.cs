using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("goBall", 2); //When the game starts, this method will be called, making the ball move
	}
	

    public void goBall()// This function set the ball's movement
    {
        float rand = Random.Range(0, 2); //Parameters indicate it must wait minimum of 0 seconds and maximum of 2 seconds

        if(rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15)); //The force added on the 2 axis is one of the secrets behind the ball's movement
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }



}

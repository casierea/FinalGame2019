using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
	
			//UnityTutorial 2d info

public class PlayerControl2d : MonoBehaviour
{

	public float speed; //float point variable to store the player's movement speed

	private Rigidbody2D rb2d;  //Store a reference to the RigidBody2D component required to use 2D physics
	// Use this for initialization
	void Start ()
	{
		rb2d = GetComponent<Rigidbody2D>(); //Get and Storeference to the RigidBody 2D componenet so that we can access it.

	}
	
	// Fixed Update is called at a fixed interval and is independent of frame rate. Put physics code here.
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");

		float moveVertical = Input.GetAxis("Vertical");

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		
		rb2d.AddForce(movement * speed);
	}
}

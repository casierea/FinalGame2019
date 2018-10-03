using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
	//public Vector3 Speed;
	public CharacterController Character;
	
	public float Speed;

	//private Vector3 MoveSpeed;

	//private Vector3 RotateSpeed;
	
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	
	private void Update()
	//update runs every single frame
	{
		// taking x speed and taking whatever our speed is,
		// we are going to times it by a
		//horizontal speed. This will make it so hit left
		//and right arrow and moves.
		
		MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
		// hortizonal is left and right arrows
	
		//regularspeed
		MoveSpeed *= Time.deltaTime; 
		
		
		//transform.Translate(MoveSpeed);
		//transform.Rotate(RotateSpeed);
		
		Character.Move(MoveSpeed);
	}

}

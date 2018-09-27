using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour

{
	//public Vector3 Speed;
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	
	private void Update()
	{
		// taking x speed and taking whatever our speed is, we are going to times it by a
		//horizontal speed. This will make it so hit left and right arrow and moves.
		
		MoveSpeed.x += Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;
		
		transform.Translate(MoveSpeed);
		transform.Rotate(RotateSpeed);
	}

}

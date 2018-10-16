using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class EnumMovements : MonoBehaviour {
	public enum MovementType
	{
		MoveX, 
		MoveY, 
		MoveZ
	}

	public MovementType CurrentMovementType;

	public Vector3 Movement;
	public float Speed;
	
	
	
	// Use this f
	//or initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		switch (CurrentMovementType)
		//which way we would liek the objec to roll inside Unity
		{
			case MovementType.MoveX:
				Movement.x = Speed;
			//Do work
				break;
			case MovementType.MoveY:
				Movement.y = Speed;
				//Do work
				break;
			case MovementType.MoveZ:
				Movement.z = Speed;
				//dow work
				break;
			
		}
		transform.Rotate(Movement);
	}
}

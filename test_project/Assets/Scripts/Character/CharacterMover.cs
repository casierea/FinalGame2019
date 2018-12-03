using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{


	public CharacterController controller;
	public float Gravity = 9.81f;
	public float MoveSpeed = 3.0f;
	public float JumpSpeed = 3.0f;
	
	private Vector3 position;
	private Vector3 rotation;

	public float MoveX;
	
	void Start ()
	{
		controller = GetComponent<CharacterController>();
	}


	void Update()
	{
		PlayerMove();
		//if (controller.isGrounded)
	}

		void PlayerMove()
			{
			//Controls
			MoveX = Input.GetAxis("Horizontal");
			//Jump Control
			if (Input.GetButtonDown("Jump") && controller.isGrounded == true)
			{
				//Jump()
			}

			if (MoveX < 0.0f)
			{
				GetComponent<SpriteRenderer>().flipX = false;
			}
			else if (MoveX > 0.0f)
			{
				GetComponent<SpriteRenderer>().flipX = true;
			}
			//This is the physics
			gameObject.GetComponent<Rigidbody>().velocity = new Vector2(MoveX * MoveSpeed,gameObject.GetComponent<Rigidbody>().velocity.y);
			}
			//position.Set(0, 0, MoveSpeed*Input.GetAxis("Horizontal"));
			//rotation.Set(0, Input.GetAxis("Vertical"), 0);
			//transform.Rotate(rotation);
			//position = transform.TransformDirection(position);
			//position.z = MoveSpeed*Input.GetAxis("Vertical");
			 //rotation.y = Input.GetAxis("Horizontal");
			 //transform.Rotate(rotation);
			 //position = transform.TransformDirection(position);
					
						//position.x = Rotate* Input.GetAxis("Horizontal");	//get axis is built into Unity
						   // Vertical is s w
							
                                
			//if (Input.GetButton("Jump"))
			//{
			//	position.y = JumpSpeed;
			//}
		//}
		//position.y -= Gravity * Time.deltaTime;
		//controller.Move(position * Time.deltaTime);
	////}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveNew : MonoBehaviour
{

	public FloatData PlayerSpeed;
	public FloatData PlayerJumpPower;
	public float DistancetoBottomOfPlayer = 1.3f;
	public bool IsGrounded;

	private float MoveX;
	

	// Update is called once per frame
	void Update ()
	{
		PlayerMove();
		PlayerRayCast();
	}

	void PlayerMove()
	{
		MoveX = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump") && IsGrounded == true)
		{
			Jump();
		}

		//animation
		if (MoveX < 0.0f)
		{
			GetComponent<SpriteRenderer>().flipX = false;
		}
		else if (MoveX > 0.0f)
		{
			GetComponent<SpriteRenderer>().flipX = true;
		
		}
		//physics
		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(MoveX * PlayerSpeed.Value, gameObject.GetComponent<Rigidbody2D>().velocity.y);
}

	void PlayerRayCast()
	{
		//Ray Down
		RaycastHit2D rayDown = Physics2D.Raycast(transform.position, Vector2.down);
		if (rayDown != null && rayDown.collider != null && rayDown.distance < DistancetoBottomOfPlayer &&
		    rayDown.collider.tag != "enemy")
		{
			IsGrounded = true;
			
		}
		else
		{
			IsGrounded = false;
		}
	}

	void Jump()
	{
		//Jumpcode
		//Debug.Log("what will print" +Variable.ToString());
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * PlayerJumpPower.Value);
		IsGrounded = false;
	}
}

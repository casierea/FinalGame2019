using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    
    public int PlayerSpeed = 10;
    public bool FacingRight =  true;
    public int PlayerJumpPower = 1250;
	public float MoveX;
	


	void Update () {
		PlayerMover();
}

void PlayerMover(){
//Controls
	MoveX = Input.GetAxis("Horizontal");
	if (Input.GetButtonDown("Jump"))
	{
		Jump();
	}
//Animatioans
//Player Direction
if (MoveX < 0.0f && FacingRight == false)
{
	FlipPlayer();
} else if (MoveX > 0.0f && FacingRight == true){
FlipPlayer();
}
//Physics
	gameObject.GetComponent<Rigidbody2D>().velocity =
		new Vector2(MoveX * PlayerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
}
void Jump(){
//Jump code
	GetComponent<Rigidbody2D>().AddForce(Vector2.up * PlayerJumpPower);
}
void FlipPlayer()
{
	FacingRight = !FacingRight;
	Vector2 localScale = gameObject.transform.localScale;
	localScale.x *= -1;
	transform.localScale = localScale;
}
}

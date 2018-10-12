using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
    public int EnemySpeed;
    public int XMoveDirection;
    
	// Update is called once per frame
	void Update ()
	{
		RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2 (XMoveDirection, 0));
		gameObject.GetComponent<Rigidbody>().velocity = new Vector2(XMoveDirection,0) * EnemySpeed;

		if (hit.distance < .7f)
		{
			Flip();
			if (hit.collider.tag == "Player")
			{
				Destroy(hit.collider.gameObject);
			}
		}

	}

	private void Flip()
	{
		XMoveDirection *= -1;
	}
}

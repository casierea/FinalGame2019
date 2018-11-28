using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
	public int Score = 0;
	
	private void OnTriggerEnter(Collider other)

	{
		print("Check");
		
		//if (other.tag == "object")
		
			Destroy(gameObject);
			print("Destroy");
			Score += 1;
		
	}
}


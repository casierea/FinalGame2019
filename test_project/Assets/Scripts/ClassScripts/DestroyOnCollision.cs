using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
	public int Score = 0;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("object"))
		{
			Destroy(other.gameObject);
			Score += 1;
		}
	}
}


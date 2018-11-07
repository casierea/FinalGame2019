using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour 
{
	private void OnTriggerEnter(Collider other)
	{   
		Debug.Log("I trigger a thing");
		Destroy(other.gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(other.gameObject);
		Debug.Log("I hit a thing");
		//Destroy(gameObject);
		//Destroy(gameObject);
		// makes bullets collide and destory eachother
	}
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollisionDestroy : MonoBehaviour
{
//On collision collect and destroy object
	
	private void OnTriggerEnter(Collider trig)
	{
		if (trig.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
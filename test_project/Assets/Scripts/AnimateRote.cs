using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateRote : MonoBehaviour {

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		var currentRotation = gameObject.transform.rotation;
		var newZ = currentRotation.z = -10;
		gameObject.transform.rotation = new Quaternion(currentRotation.x, currentRotation.y, newZ, currentRotation.w);
	}
}

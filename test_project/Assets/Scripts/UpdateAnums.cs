using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAnums : MonoBehaviour
{

	private Animator anims;
	public float Speed;
	
	void Start ()
	{
		anims = GetComponent<Animator>();
	}
	
	void Update () {
		anims.SetFloat("Speed", Speed);
	}
}

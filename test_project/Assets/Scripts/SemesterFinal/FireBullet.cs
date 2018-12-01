using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine.Editor;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
	public GameObject Instance;
	
	public int BulletForce = 100;
	public GameObject Player;
	public ClassCharacterMover CCM;

	private float rotatex;
	// Update is called once per frame
	void Start()
	{
		CCM = Player.GetComponent<ClassCharacterMover>();
		rotatex = transform.rotation.x;
	}
	
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
		}
	}

	private void Shoot()
	{
		GameObject Bullet;
		Bullet = Instantiate(Instance, transform.position, transform.rotation);
		if( CCM.FacingLeft == true) 
		//if(gameObject.GetComponentInParent<SpriteRenderer>().flipX)
		{	
			//BulletForce = BulletForce * -1;
			BulletForce = BulletForce;
			print("shooting left");
			
			Bullet.GetComponent<Rigidbody>().AddForce(-BulletForce,0,0);
		}
		else if (CCM.FacingLeft == false)
		//else if(gameObject.GetComponentInParent<SpriteRenderer>().flipX == false)
		{
			//BulletForce = Math.Abs(BulletForce);
			
			//BulletForce = 100;
			print("shooting right");
			Bullet.GetComponent<Rigidbody>().AddForce(BulletForce,0,0);	
			
		}
		
	}
}	

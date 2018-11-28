using System;
using System.Collections;
using System.Collections.Generic;
using Cinemachine.Editor;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
	public GameObject Instance;
	
	public int BulletForce = 100;
	
	// Update is called once per frame
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
		if(gameObject.GetComponentInParent<SpriteRenderer>().flipX != true)
		{
			//BulletForce = BulletForce * -1;
			BulletForce = -100;
			Debug.Log(BulletForce.ToString() + gameObject.GetComponentInParent<SpriteRenderer>().flipX);
			
			Bullet.GetComponent<Rigidbody>().AddForce(BulletForce,0,0);
		}
		else if (GetComponentInParent<SpriteRenderer>().flipX)
		{
			//BulletForce = Math.Abs(BulletForce);
			BulletForce = 100;
			Bullet.GetComponent<Rigidbody>().AddForce(BulletForce,0,0);	
		}
		
	}
}	

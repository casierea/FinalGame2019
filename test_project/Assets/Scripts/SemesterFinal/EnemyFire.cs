using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour

{
	public Transform WeaponPosition;
	public GameObject EnemyShoot;
	public FloatData BulletSpeed;
	private float ShootyForce;
	private bool FacingRight;
	private void Update()
	{
		FacingRight = gameObject.GetComponentInParent<SpriteRenderer>().flipX;
	}

	private void OnTriggerEnter(Collider other)
	{	Debug.Log("Player tag");
		
		if (other.tag == "Player")
		{
			StartCoroutine("BeginShoot");
		}
	}

	IEnumerator BeginShoot()
	{
		while (true)
		{	Debug.Log("in Whileloop");
			if (FacingRight == false)
			{
				ShootyForce = -BulletSpeed.Value;
			}
			else
			{
				ShootyForce = BulletSpeed.Value;
			}
			GameObject Clone;
			Clone = Instantiate(EnemyShoot, WeaponPosition.position, Quaternion.identity);
			Clone.GetComponent<Rigidbody>().AddForce(ShootyForce,0,0);
			yield return new WaitForSeconds(1);
		}
		

	}

}
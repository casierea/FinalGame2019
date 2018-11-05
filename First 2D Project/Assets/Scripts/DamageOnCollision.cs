using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{

	public int DamageAmount;
	
	private void OnTriggerEnter2D(Collider2D trig)
	{
		if (trig.gameObject.tag == "Player")
		{
			trig.gameObject.GetComponent<PlayerHealthStats>().TakeDamage(DamageAmount);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObjectCollDamage : MonoBehaviour
{

	public FloatData Damage;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<ObjectHealth>())
		{
			other.GetComponent<ObjectHealth>().DamageHealth(Damage.Value);
		}
		
	}
}

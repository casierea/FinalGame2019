using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnObjectCollDamage : MonoBehaviour
{

	public FloatData Damage;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.GetComponent<RedoObjHealth>())
		{
			other.GetComponent<RedoObjHealth>().DamageHealth(Damage.Value);
		}

		if (other.gameObject.GetComponent<MultiObjHealth>())
		{
			other.GetComponent<MultiObjHealth>().DamageHealth(Damage.Value);
		}
	}
}

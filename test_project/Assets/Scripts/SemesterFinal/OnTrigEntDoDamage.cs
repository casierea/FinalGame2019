using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigEntDoDamage : MonoBehaviour
{

	public FloatData DamageAmount;

	public GameObject DamageTarget;
	// damage Target must have RedoObjHealth script

	private void OnTriggerEnter(Collider other)
	{
		other.GetComponent<RedoObjHealth>().DamageHealth(DamageAmount.Value);
	}

}

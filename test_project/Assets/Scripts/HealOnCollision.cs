using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealOnCollision : MonoBehaviour {

    public FloatData Heal;
	
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<RedoObjHealth>())
        {
            other.GetComponent<RedoObjHealth>().DamageHealth(Heal.Value);
        }

        if (other.gameObject.GetComponent<MultiObjHealth>())
        {
            other.GetComponent<MultiObjHealth>().DamageHealth(Heal.Value);
        }
    }
}


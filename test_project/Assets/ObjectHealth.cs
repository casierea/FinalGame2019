using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHealth : MonoBehaviour
{
	public FloatData MaxHealth;
	public FloatData MinHealth;
	public FloatData StartHealth;
	public float CurrentHealth;
	

	// Use this for initialization
	private void Start ()
	{
		CurrentHealth = StartHealth.Value;
	}

	private void Update()
	{
		ZeroHealth();
	}

	public void DamageHealth(float damage)
	{
		if (CurrentHealth > MinHealth.Value)
		{
			CurrentHealth -= damage;
		}
	}

	public void HealHealth(float heal)
	{
		if (CurrentHealth < MaxHealth.Value)
		{
			CurrentHealth += heal;
		}
	}

	public void ZeroHealth()
	{
		if (CurrentHealth <= MinHealth.Value)
		{
			//die
			gameObject.GetComponent<BoxCollider>().enabled = false;
			gameObject.GetComponent<CharacterController>().enabled = false;
			if (gameObject.GetComponent<Rigidbody>() != null)
			{
				gameObject.GetComponent<Rigidbody>().freezeRotation = false;
			}
			
		}
	}
	
}

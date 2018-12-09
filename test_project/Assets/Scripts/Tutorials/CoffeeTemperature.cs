using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CoffeeTemperature : MonoBehaviour
{

	public float CoffeeTemp = 120f;
	public float CoffeeHotLimit = 100f;
	public float CoffeeColdLimit = 60f;
	public float NotDrinkable = 20f;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		CoffeeTemp -= Time.deltaTime * 5f;
	}

	void TemperatureTest()
	{
		if (CoffeeTemp > CoffeeHotLimit)
		{
			print("Coffe is too hot. Can not haz.");
		}
		else if (CoffeeTemp < CoffeeColdLimit)
		{
			print("Coffe is too cold. Does not want.");	
		}
		else
		{
			print("Coffee is Good. Can Haz");
		}
	}
}

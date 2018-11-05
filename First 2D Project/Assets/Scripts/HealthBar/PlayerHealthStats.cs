using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System; 
using UnityEngine;
using UnityEngine.UI;
//using Slider = UnityEngine.Experimental.UIElements.Slider;

public class PlayerHealthStats : MonoBehaviour
{
//Public Variables

	public Slider HealthBarSlider;
	public Text HealthText;
	

//variables For Damage Flash

	public Image DamageImage;
	public float DamageFlashspeed = 3f;
	public Color DamageFlashColor = new Color(1f, 0f, 0f, 0.1f);

	//Varoables for Heal Health
	public Image HealImage;
	public float HealFlashSpeed = 3f;
	public Color HealFlashColor= new Color(1f, 0f, 0f, 0.1f);

	private int maxHealth = 100;
	private int miniumHealth = 0;
	private float currentHealth = 100;
	private bool damaged = false;
	private bool healing = false;

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (HealthBarSlider != null)
		{
			UpdateHealthBar();
		}

		if (HealthText != null)
		{
		//UpDateHealthText("PerecentInt");
		}

		//DamageFlash();
		//HealFlash();
		LockMinMaxHealth();
	}

	//public void UpDateHealthText(string perecentint);
	
	public void SetMaxHealth(int newMaxHealth)
	{
		maxHealth = newMaxHealth;
	}

	public int GetMaxHealth()
	{
		return maxHealth;
		
	}
	
	//SetCurrentHealth updates the health value
	public void SetCurrentHealth(int newCurrentHealth)
	{
		currentHealth = newCurrentHealth;
	}
	//GetCurrentHealth returns the current health value
	public float GetCurrentHealth()
	{
		return currentHealth;
	}
	//LockMinMaxHealth sunsures the players health never goes over the maxhealth of under the minimumHealth
	public void LockMinMaxHealth()
	{
		//If health Ddropper below the minimum health set current health to minimom health
		if (currentHealth < miniumHealth)
		{
			currentHealth = miniumHealth;
		}
		//if healing increases current health abovemax health set current health to max health
		if (currentHealth > maxHealth)
		{
			currentHealth = maxHealth;
		}
	}
	//TakeDamage subtracts the supplied damage amount from the player currrent health
	public void TakeDamage(int damageAmount)
	{
		//Flagged damage as true so other functions know you just took damage
		damaged = true;
		
		//Only reduce health if you have health to reduce
		if (currentHealth > miniumHealth)
		{
			currentHealth = currentHealth - damageAmount;
		}
	}
	//Heal increases the current health by the supplied amount
	public void Heal(int healAmount)
	{
		healing = true;
		//Only increase current health if it is less than max health

		if (currentHealth < maxHealth)
		{
			currentHealth = currentHealth + healAmount;
		}
		
	}

	public void UpdateHealthBar()
	{
		HealthBarSlider.maxValue = maxHealth;
		HealthBarSlider.value = currentHealth;
	}

	public void UpdateHealthText(string displayHow)
	{	//shows a truncated version of current health.( int portion)
		//HealthText.text = Math.Truncate(currentHealth).ToString();
		if (displayHow == "Int")
		{
			HealthText.text == Math.Truncate(currentHealth).ToString();
		}
		else if (displayHow == "Float")
		{
			HealthText.text = currentHealth.ToString();
		}
		else if (displayHow == "PercentFloat")
		{
			HealthText.text = ((currentHealth / maxHealth) * 100).ToString() + "%";
		}
		else if (displayHow == "PercentInt")
		{
			HealthText = Math.Truncate((currentHealth / maxHealth) * 100).ToString() + "%";
		}
		//Debug
		Debug.Log("The Value supplied to HealthManage.UpdateHealthText is not one of the available options");
	}
}
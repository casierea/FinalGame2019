using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Slider = UnityEngine.Experimental.UIElements.Slider;

	public class PlayerHealthStats : MonoBehaviour
//Public Variables

	public Slider HealthBarSlider;
	public Text HealthText;
	
//variables For Damage Flash

	public Image DamageImage;
	public float damageFlashspeed = 3f;
	public Color damageFlashColor =  new Color(1f, 0f, 0f, 0.1f);

	//Varoables for Heal Health
	public Image HealImage;
	public float healFlash = 3f;
	public Color healFlashSpeed = new Color(1f, 0f, 0f, 0.1f);
	
	private int maxhealth = 100;
	private int miniumHealth = 0;
	private float currentHealth = 100;
	private bool damaged = false;
	private bool healing = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

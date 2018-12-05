using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Experimental.UIElements;


public class UpDateImageValue : MonoBehaviour
{


	public FloatData Data;

	private Image image;
	
	// Use this for initialization
	void Start ()
	{
		image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		image.fillAmount = Data.Value;
	}
}

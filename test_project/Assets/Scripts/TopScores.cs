using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopScores : MonoBehaviour
{
	public string[] PlayerNames;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < PlayerNames.Length; i++)
		{
			print (PlayerNames [i]);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

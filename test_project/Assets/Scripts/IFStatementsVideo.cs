using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatementsVideo : MonoBehaviour
{
	public int A;
	public int B;
	public int C; 
	
	public string Password;
	public bool OnSwitch;
	void Update () {
		//
		if (OnSwitch)
		{
			print("The Light is on");
		}

		else
		{
			print("No light. Can not haz.");
		}

		//
		if (Password == "Pikachu")
		{
			print("Correct!");
		}
		else
		{
			print("Not the password. Thanks anyway.");
		}

		//
		if (A + B == C)
		{
			print("A plus B equals C");

		}
	}
}

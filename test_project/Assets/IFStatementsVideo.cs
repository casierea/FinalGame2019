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
		if (OnSwitch)
		{
			print("The Light is on");
		}

		if (Password == "Pikachu") ;
		{
			print("Correct!");
		}

		if (A + B == C)
		{
			print("A plus B equals C");

		}
	}
}

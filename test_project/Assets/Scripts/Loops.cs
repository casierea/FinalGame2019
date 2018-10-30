using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Loops : MonoBehaviour
{

	public string[] Names;
	public GameObject [] Things;
	public GameObject[] Shapes;
	public string[] Ducks;
	public GameObject [] Anphibians;
	
	// Use this for initialization
	void Start ()
	{
		for (int i = 0; i < Names.Length; i++)
		{
			print(Names[i]);
		}

		foreach (var thing in Things)
		{
			print(thing);
		}

		foreach (var shape in Shapes)
		{
			print(shape);	
		}

		foreach (var duckie in Ducks)
		{
			print(duckie);
		}

		foreach (var frog in Anphibians)
		{
			print(frog);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

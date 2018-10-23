using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour
{

	public int A;

	public int B;

	public int C;
	// Use this for initialization
	void Start ()
	{
		//C = A +B;
		//C++;
		C += A;
		C --;
		C = A - B;
		C -= A;
		C = A * B;
		C *= A;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

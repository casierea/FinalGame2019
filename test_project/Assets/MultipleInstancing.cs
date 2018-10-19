using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleInstancing : MonoBehaviour
{

	public GameObject InstanceTwo;
	public GameObject InstanceThree;
	public GameObject InstanceFour;

	void Update()
	{
		//if (Input.GetMouseButtonDown(0))
			if (Input.GetKeyDown(KeyCode.D)) // could do GetButtonDown and use mouse button
			{
				Instantiate(InstanceTwo, transform.position, transform.rotation);

			}

		if (Input.GetKeyDown(KeyCode.C))
		{
			Instantiate(InstanceThree, transform.position, transform.rotation);
		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			Instantiate(InstanceFour, transform.position, transform.rotation);
		}

	}
}
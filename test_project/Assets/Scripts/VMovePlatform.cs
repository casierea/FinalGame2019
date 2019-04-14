using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VMovePlatform : MonoBehaviour
{

	public int BlockSpeed = 4;
	public int YMoveDirection = -1;
	public Vector3Data Destination1;
	public Vector3Data Destination2;
	public Vector3 CurrentDestination;
	

	// Use this for initialization
	void Start ()
	{
		CurrentDestination = Destination1.Value;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, YMoveDirection,0) * BlockSpeed;
		switchDestination();
	}

	private void switchDestination()
	{
		if (Vector3.Distance(transform.position, CurrentDestination) < 2.0f)
		{
			Flip();

			if (CurrentDestination == Destination1.Value)
			{
				CurrentDestination = Destination2.Value;
			}
			else if (CurrentDestination == Destination2.Value)
			{
				CurrentDestination = Destination1.Value;
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Flip();
		if (CurrentDestination == Destination1.Value)
		{
			CurrentDestination = Destination2.Value;
		}
		else if (CurrentDestination == Destination2.Value)

		{
			CurrentDestination = Destination1.Value;
		}
	}

	private void Flip()
	{
		YMoveDirection *= -1;
	}
}

	


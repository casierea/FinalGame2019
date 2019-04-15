using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HMovePlatform : MonoBehaviour
{

	public int BlockSpeed = 4;

	public int XMoveDirection = -1;

	public Vector3Data Destination1;

	public Vector3Data Destination2;

	public List<Vector3Data> PatrolPoints = new List<Vector3Data>();

	private Vector3 CurrentDestination;
	
	// Use this for initialization
	void Start ()
	{
		PatrolPoints.Add(Destination1);
		PatrolPoints.Add(Destination2);
		CurrentDestination = Destination1.Value;
	}
	
	// Update is called once per frame
	void Update ()
	{
		gameObject.GetComponent<Rigidbody>().velocity = new Vector3(XMoveDirection, 0) * BlockSpeed;
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

	private void OnCollisionEnter(Collision other)
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
		XMoveDirection *= -1;
	}
}

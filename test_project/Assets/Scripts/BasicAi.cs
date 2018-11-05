
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{
	private NavMeshAgent agent;
	public Transform Destination;
	
	
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	

	void Update ()
	{
		if (Destination != null) agent.destination = Destination.position;
	}
}

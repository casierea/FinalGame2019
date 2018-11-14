
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{
	private NavMeshAgent agent;

	//public Transform Destination;
	public Transform Target;
	//public Transform Destination3;


	void Start()
	{
		agent = GetComponent<NavMeshAgent>();
	}


	void Update()
	{
		//if (Destination != null) agent.destination = Destination.position;
		if (Target != null) agent.destination = Target.position;
	}

}

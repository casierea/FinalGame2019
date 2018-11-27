
using UnityEditor.Experimental.UIElements.GraphView;
using UnityEngine;
using UnityEngine.AI;

public class BasicAi : MonoBehaviour
{
	private NavMeshAgent agent;
//new information from player controller script
	private Quaternion lookLeft;
	private Quaternion lookRight;
	
	//public Transform Destination;
	public Transform Target;
	public Transform Target02;
	

	void Start()
	{
		agent = GetComponent<NavMeshAgent>();

		lookRight = transform.rotation;
		lookLeft = lookRight * Quaternion.Euler(0, 180, 0);
	}


	void Update()
	{
		//if (Destination != null) agent.destination = Destination.position;
		if (Target != null) agent.destination = Target.position;
		
		if (Target.position.x <= gameObject.transform.position.x)
		{
			transform.rotation = lookLeft;
		}
		else if (Target.position.x < gameObject.transform.position.x)
		{
			transform.rotation = lookRight;
			
		}
		var currentPosition = gameObject.transform.position;
		gameObject.transform.position = new Vector3(currentPosition.x,currentPosition.y,0f);
	}	

}
	


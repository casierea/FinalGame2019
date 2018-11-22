using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiHitandGo : MonoBehaviour {

    private NavMeshAgent agent;
	
    //dynamically set distination based on starting position of AI enermies
    public Vector3Data Destination1;
    public Vector3Data Destination2;
    //public Vector3 Destination3;
    public List<Vector3Data> PatrolPoints = new List<Vector3Data>();
    private int currentDestinationIndex = 0;
	
    // Use this for initialization
    void Start ()
    {
        agent = GetComponent<NavMeshAgent>();
        //agent.destination = Destination1.Value;
        PatrolPoints.Add(Destination1);
        PatrolPoints.Add(Destination2);
        agent.destination = PatrolPoints[0].Value;
        Debug.Log(agent.destination.ToString());
    }
	
    // Update is called once per frame
    void Update ()
    {
        switchDestination();
    }

    private void switchDestination()
    {
        // if (Vector3.Distance(transform.position, Destination1.Value) < 1.0f)
        if (Vector3.Distance(transform.position, agent.destination) < 1.0f)
        {
            currentDestinationIndex += 1;
            if (currentDestinationIndex > PatrolPoints.Count - 1)
            {
                currentDestinationIndex = 0;
            }

            agent.destination = PatrolPoints[currentDestinationIndex].Value;
        }
    }
    //on collision
	
    private void OnTriggerEnter(Collider trig)
    {
        var bump = new Vector3(-10f, -20f, 0f);
        if (trig.gameObject.tag == "Player")
        {
            Debug.Log("triggered by Player");
            // do damage
            trig.gameObject.GetComponent<ObjectHealth>().DamageHealth(5);
            trig.gameObject.GetComponent<CharacterController>().SimpleMove(bump * 5f);
            //push player
            //change destination

        }
        else
        {
            //change destination
        }
    }
	
}

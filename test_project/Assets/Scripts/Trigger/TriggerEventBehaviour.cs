using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{

	public UnityEvent Enable;
	public UnityEvent Trigger;
	
	void OnEnable()
	{
		Enable.Invoke();
	}

	void OnTriggerEnter()
	{
		Trigger.Invoke();
	}
}

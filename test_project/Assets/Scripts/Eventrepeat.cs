using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventrepeat : MonoBehaviour
{
	public UnityEvent[] OnReapeat;
	
	public float Seconds = 2;
	private int i = 0;
	
		IEnumerator Start(){
			while (true)
			{
				yield return new WaitForSeconds(Seconds);
				
				OnReapeat[i].Invoke();
				
				if (i < OnReapeat.Length-1)
				{
					i++;
				}
				else
				{
					i = 0;
				}
				
			}

	}
}
	

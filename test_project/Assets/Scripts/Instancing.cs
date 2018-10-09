using System.Collections;
using UnityEngine;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;
	
	// Use this for initialization
	void Update ()
	{
		if (Input.GetMouseButtonDown(0))
		//if (Input.GetKeyDown(KeyCode.X)) // could do GetButtonDown and use mouse button
		{
			Instantiate(Instance, transform.position, transform.rotation);
			
									//yield return new WaitForSeconds(1);
		} 
									// quat= rotate values
	}
}

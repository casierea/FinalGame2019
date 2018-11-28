using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Nov27Instancer : MonoBehaviour {
	
	private Vector3 position;
    
	public GameObject prefab;

	public void InstanceObject(GameObject prefab)
	{
		position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		position.z = 0;
		Instantiate(prefab, position, Quaternion.identity);
	}
}

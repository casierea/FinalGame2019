using System.Collections;
using System.Collections.Generic;
using Cinemachine.Editor;
using UnityEngine;

public class EnemyFire : MonoBehaviour

{
	public GameObject EnemyShoot;

	IEnumerator Start()
	{
		while (true)
		{
			Instantiate(EnemyShoot, transform.position, Quaternion.identity);
			yield return new WaitForSeconds(1);
		}

	}

}
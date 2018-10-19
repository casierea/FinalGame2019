using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class TwithInstance : MonoBehaviour
{

	public GameObject Instance;

	 private void Start ()
	 {
		 Instantiate(Instance);
	 }
	

}

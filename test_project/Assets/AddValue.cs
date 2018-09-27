using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class AddValue : ScriptableObject
{
	public FloatData ValueObj;
	public FloatData MaxValue;
	public FloatData MinValue;
	
//something else that can do. not needed for script
	public UnityEvent EventMax;
	public UnityEvent EventMin;

	public void AddValueToObject(FloatData data)
	{
		ValueObj.Value += data.Value;

		//more for fun
		if (ValueObj.Value >= MaxValue.Value)
		{
			EventMax.Invoke();
		}
		if (ValueObj.Value <= MinValue.Value)
		{
			EventMin.Invoke();

		}
		}

		
	}
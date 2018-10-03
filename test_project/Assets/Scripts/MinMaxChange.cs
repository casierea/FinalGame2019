//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Runtime.InteropServices;
//using UnityEngine;
//using UnityEngine.Events;
//
//[CreateAssetMenu]
//
//public class MinMaxChangeValue : ScriptableObject
//{
//	public FloatData ChangeValue;
//	public FloatData MaxValue;
//	public FloatData MinValue;
//	public object gameObject
//
//////something else that can do. not needed for script
//	public UnityEvent EventMax;
//	public UnityEvent EventMin;
//	
//
//	public void AddValueToObject(FloatData data)
//	{
//		data.Value += ChangeValue.Value;
//		//more for fun
//	if (ChangeValue.Value >= MaxValue.Value)
//	{
//			EventMax.Invoke();		}
//
//		if (ChangeValue.Value <= MinValue.Value)
//		{
//			EventMin.Invoke();
//
//		}
//	}



//Not needed to create an event with min and max and invoke.





	//public void SubtractValueFromObject(FloatData data)
	//	{
	//		data.Value -= ChangeValue.Value;
	//	
	//	}
	
	//	public void MultiplyValueBy(FloatData data)
	//	{
	//		data.Value *= ChangeValue.Value;
	//	}

	//	public void DivideValueBy(FloatData data)
	//	{
	//		if (ChangeValue.Value != 0.0f)
//			{
//				data.Value /= ChangeValue.Value;
//			}
//		}
//	}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class DivideByValue : ScriptableObject
{

	public FloatData ObjValue;
	
	
	public void DivideValueBy(FloatData data)

    {
        if (ObjValue.Value != 0) //checking to make sure donot divide by  zero.
        {
            data.Value /= ObjValue.Value;
        }

    }
}

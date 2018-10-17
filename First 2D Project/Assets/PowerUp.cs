using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[CreateAssetMenu]

public class PowerUp : ScriptableObject
{
	public FloatData Data;
    
	public void OnPowerUp(FloatData outsideData)
	{
		outsideData.Value += Data.Value;
	}
}

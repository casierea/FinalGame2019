using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangePowerValue : ScriptableObject {


//Add Value
    public FloatData Data;
    
    public void OnPowerUp(FloatData outsideData)
    {
        outsideData.Value += Data.Value;
    }
//Subtract Value
    public void OnPowerDown(FloatData outsideData)
    {
        outsideData.Value -= Data.Value;
    }
}


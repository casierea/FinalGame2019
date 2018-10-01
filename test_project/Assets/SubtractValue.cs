using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class SubtractValue : ScriptableObject


{
    public FloatData ValueObj;

    public void SubtractValueFromObject(FloatData data)
    {
        data.Value -= ValueObj.Value;
    }

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MulitiplyAndDivide : ScriptableObject

{ //ObjValue = Ten Asset 
    public FloatData ObjValue;

    // function called MultiplayValueBy that acts on data.
    public void MultiplyValueBy(FloatData data)
    {
        data.Value *= ObjValue.Value;
       
    }

//    public void DivideValueBy(FloatData data)
//
//    {
//        if (ObjValue.Value != 0) //checking to make sure donot divide by  zero.
//        {
//            data.Value /= ObjValue.Value;
//        }
//
//    }
}

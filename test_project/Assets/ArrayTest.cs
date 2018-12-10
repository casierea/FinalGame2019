using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public string[] BadGuys;
    public int[] Numbers;
    public int[] ThreeNums = {5,6,9}; 
    
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < ThreeNums.Length; i++)
        {
            Debug.Log("help"+i);
            Debug.Log(ThreeNums[i]);
        }
        for (int i = 0; i < BadGuys.Length; i++)
        {
            print(BadGuys[i]);
            Debug.Log(BadGuys[i]);
        }
        foreach (var number in Numbers)
        {
            print(number);	
        }
    }

   
}

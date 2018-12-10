using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public string[] BadGuys;
    public int [] Numbers; 

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < BadGuys.Length; i++)
        {
            print(BadGuys[i]);
        }
        foreach (var number in Numbers)
        {
            print(number);	
        }
    }
}

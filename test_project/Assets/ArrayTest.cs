using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public string[] BadGuys;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < BadGuys.Length; i++)
        {
            print(BadGuys[i]);
        }
    }
}

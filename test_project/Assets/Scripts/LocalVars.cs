using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
    public string Name;

    public void Call()
    {
        Name = "Bob";
        print(Name);
    }

    public void Call(string newName)
    {
        print(newName);
        print(Name);
    }
}

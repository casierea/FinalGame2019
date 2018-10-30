using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class PowSo : ScriptableObject
{
    public PowerUpStates.PowerStates PowerUp;

    public UnityEvent OneUp, SparkleRay, StarStruck, RoboBoogie, SteamUp;
	
	
    // Use this for initialization
    void Start () {
		
    }
	
    // Update is called once per frame
    void Update () {
        switch (PowerUp)
        {
            case PowerUpStates.PowerStates.OneUp:
                break;
				
            case PowerUpStates.PowerStates.SparkleRay:
                break;
				
            case PowerUpStates.PowerStates.StarStruck:
                break;
				
            case PowerUpStates.PowerStates.RoboBoogie:
                break;
				
            case PowerUpStates.PowerStates.SteamUp:
                break;
        }
		
    }
}






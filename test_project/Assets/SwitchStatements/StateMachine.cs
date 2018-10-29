using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class StateMachine : ScriptableObject{
public GameStates.States GameState;
public UnityEvent Starting, Loading, Playing, Ending, Dying;
	
//StateMachine.Can do a unityevent.
	
// Use this for initialization
void Start () {
		
}
	
// Update is called once per frame
public void Run () {
switch (GameState)
{
case GameStates.States.Starting:
//print("We are starting the Game.");
break;
				
case GameStates.States.Loading:
//print("Loading!");
break;
				
case GameStates.States.Playing:
//print("We are playing the Game.");
break;
				
case GameStates.States.Ending:
//print("We are ending the Game.");
break;
					
}
}
}

	
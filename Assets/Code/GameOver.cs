using UnityEngine;
using System.Collections.Generic;

public class GameOver : IStateBase {
	private StateManager manager;
	
	public GameOver(StateManager managerRef) {
		manager = managerRef;
		
		Debug.Log ("GameOver");
	}
	
	public void StateUpdate(){
		
	}
	
	public void ShowIt(){
		if(GUI.Button(new Rect(10,10, (Screen.width) - 20, (Screen.height) - 20), "go to Main Menu")){
			manager.SwitchState(new MainMenu(manager));
		}
	}
}

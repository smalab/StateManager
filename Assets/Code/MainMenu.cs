using UnityEngine;
using System.Collections.Generic;

public class MainMenu : IStateBase {

	private StateManager manager;

	public MainMenu(StateManager managerRef) {
		manager = managerRef;
		Debug.Log ("Main Menu");
	}

	public void StateUpdate(){
	}

	public void ShowIt(){
		if(GUI.Button (new Rect (5, (Screen.height) * 2 / 3, (Screen.width) - 10, 50), "Start")){
			manager.SwitchState (new GameLevel1 (manager));
		}
	}
}

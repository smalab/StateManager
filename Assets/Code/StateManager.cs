using UnityEngine;
using System.Collections;

public class StateManager : MonoBehaviour {
	private IStateBase activeState;

	private static StateManager instanceRef;

	void Start(){
		activeState = new MainMenu(this);
	}

	void Update(){
		if(activeState != null){
			activeState.StateUpdate();
		}
	}

	void OnGUI(){
		if(activeState != null){
			activeState.ShowIt();
		}
	}

	public void SwitchState(IStateBase newState){
		activeState = newState;
	}
}
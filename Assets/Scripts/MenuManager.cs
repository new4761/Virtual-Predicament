using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public float MaxTimeFocus;
	public int ActionID {
		private get {
			return ActionID;
		}
		set {
			ActionID = value;
		}
	}
	public bool IsFocus {
		private get {
			return IsFocus;
		}
		set {
			IsFocus = value;
		}
	}

	private bool isLoading;
	private float timeFocus;

	private void Start() {
		isLoading = false;
	}
	private void Update() {
		GazeUI();
	}
	private void GazeUI() {
		if (IsFocus && !isLoading) {
			if (timeFocus + MaxTimeFocus < Time.time) {
				CallActionID(ActionID);
			}
		} else {
			timeFocus = Time.time;
		}
	}
	private void CallActionID(int actionID) {
		switch (actionID) {
			case 0:
				isLoading = true;
				SceneManager.LoadSceneAsync(2);
				break;
			case 1:
				break;
		}
	}
}
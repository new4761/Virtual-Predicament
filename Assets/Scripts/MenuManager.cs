using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public float MaxTimeFocus;
	public string ActionName { get; set; }
	public bool isFocus { get; set; }

	private bool isLoading = false;
	private float timeFocus;

	private void Update() {
		if (isFocus && !isLoading) {
			if (timeFocus + MaxTimeFocus < Time.time) {
				CallActionID(ActionName);
			}
			return;
		}
		timeFocus = Time.time;
	}

	private void CallActionID(string actionID) {
		switch (actionID) {
			case "Load Situation One":
				isLoading = true;
				SceneManager.LoadSceneAsync(2);
				break;
			case "  ":
				break;
		}
	}
}
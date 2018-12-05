using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeInputController : MonoBehaviour {
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
		if (IsFocus && !isLoading) {
			if (timeFocus + MaxTimeFocus < Time.time) {
				//CallActionID(ActionID);
			}
		} else {
			timeFocus = Time.time;
		}
	}

}

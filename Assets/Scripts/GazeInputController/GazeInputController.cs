using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.Serialization;

public class GazeInputController : MonoBehaviour {
	public GameObject CallBack;

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
		IsFocus = false;
	}
	private void Update() {
		if (IsFocus && !isLoading) {
			if (timeFocus + MaxTimeFocus < Time.time) {
				CallBack.SendMessage("");
			}
		} else {
			timeFocus = Time.time;
		}
	}

}

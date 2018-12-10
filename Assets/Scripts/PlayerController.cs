using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

	public float speed = 6.0f;

	private CharacterController controller;

	private void Start() {
		controller = GetComponent<CharacterController>();
	}
	private void Update() {
		if (Input.GetButton("Fire1") || Input.touchCount > 0) {
			controller.Move(Camera.main.transform.TransformDirection(Vector3.forward) * speed * Time.deltaTime);
		}
		if (Input.GetButton("Fire2")) {

		}
		if (Input.GetButton("Cancel")) {
			Time.timeScale = 0f;
		}
	}
}

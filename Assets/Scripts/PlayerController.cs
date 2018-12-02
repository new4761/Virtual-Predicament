using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour {

	public float speed;

	private CharacterController player;
	private Rigidbody rigidbody;

	private void Start() {
		player = GetComponent<CharacterController>();
		rigidbody = GetComponent<Rigidbody>();
	}
	private void Update() {
		var horizontal = Input.GetAxis("Horizontal");
		var vertical = Input.GetAxis("Vertical");
		player.Move(Vector3.forward);
	}
}

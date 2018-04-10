using UnityEngine;
using System.Collections;

// Plays a sound as the player walks on ground.
public class GroundSound : Sound {

	// The rigidbody attached to the player.
	CharacterController controller;
	// The walking speed of the player.
	float maxSpeed;
	// Timer for recurring sound.
	int timer = 0;

	// Whether the player is on the ground.
	bool onGround = false;

	// Use this for initialization.
	new void Start () {
		base.Start ();
		controller = GetComponent<CharacterController> ();
		maxSpeed = GetComponent < CharacterMotor> ().movement.maxForwardSpeed;
	}
	
	// Update is called once per frame.
	void Update () {
		if (onGround) {
			float playerSpeed = Vector3.Magnitude (controller.velocity);
			if (playerSpeed > 1 && timer-- < 0) {
				timer = Mathf.Min ((int) (maxSpeed / playerSpeed * 25), 25);
				PlaySound();
			}
		}
	}

	// Checks if the player has hit the ground.
	void OnTriggerEnter (Collider collider) {
		if (collider.name == "Ground") {
			timer = 0;
			onGround = true;
			Update ();
		}
	}

	// Checks if the player has left the ground.
	void OnTriggerExit (Collider collider) {
		if (collider.name == "Ground") {
			onGround = false;
		}
	}
}

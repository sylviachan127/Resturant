using UnityEngine;
using System.Collections;

// Stops if the player gets in the way.
public class Car : PathMover {

	// Whether the car has stopped due to the player being in the way.
	[HideInInspector]
	public bool stopped = false;
	// The moving speed of the car.
	float startSpeed;
	// The amount that speed is changed every tick when changing states.
	float speedIncrement;

	// The audio source attached to the car.
	AudioSource source;

	// Use this for initialization.
	new void Start () {
		source = GetComponent<AudioSource> ();
		startSpeed = speed;
		speedIncrement = startSpeed / 40;
		base.Start ();
	}
	
	// Update is called once per frame.
	new void Update () {
		if (stopped) {
			if (speed > 0) {
				speed -= speedIncrement;
			} else if (speed < 0) {
				speed = 0;
			}
		} else {
			if (speed < startSpeed) {
				speed += speedIncrement;
			}
			source.volume = speed / startSpeed / 5;
			source.pitch = Mathf.Min (1, (speed * speed) / (startSpeed * startSpeed));
		}
		base.Update ();
	}
}

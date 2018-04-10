using UnityEngine;
using System.Collections;

// Plays a sound when the player gets within range of a certain collider.
public class RangeSound : Sound {
	
	[Tooltip("The delay time (in seconds) after the sound stops before it can play again.")]
	public float timeDelay;
	[Tooltip("A specified clip to play when the player is in range.")]
	public AudioClip clip;
	// Timer to keep track of the delay.
	float timer;

	// Use this for initialization.
	new void Start () {
		timer = 0.0f;
		base.Start ();
		if (clip == null) {
			clip = source.clip;
		}
	}

	// Update is called once per frame.
	void Update () {
		timer = timer - 1.0f;
	}

	// Plays the sound when the player hits the collider.
	protected override void OnPlayerCollide (Collider collider) {
		if (timer <= 0) {
			source.Stop();
			source.PlayOneShot (clip);
			timer = timeDelay * 60;
		}
	}
}

using UnityEngine;
using System.Collections;

// Plays when the player is in a certain area.
public class AmbientSound : Sound {

	// Starts the sound when the player enters the area.
	protected override void OnPlayerCollide (Collider collider) {
		source.Play ();
	}

	// Stops the sound when the player leaves the area.
	protected override void OnPlayerCollideExit (Collider collider) {
		source.Stop ();
	}
}

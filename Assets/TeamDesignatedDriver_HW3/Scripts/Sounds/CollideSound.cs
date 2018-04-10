using UnityEngine;
using System.Collections;

// Plays a sound when the player collides with the object.
// Varies in volume depending on how fast the player was moving.
public class CollideSound : Sound {

	// Plays a sound upon colliding with the player.
	protected override void OnPlayerCollide (Collider collider) {
		source.volume = Vector3.Magnitude (collider.GetComponent <CharacterController> ().velocity) / 6;
		PlaySound ();
	}
}

using UnityEngine;
using System.Collections;

// An object with an audio source reference.
[RequireComponent(typeof(AudioSource))]
public abstract class Sound : MonoBehaviour {
	
	[Tooltip("The audio source to play sound from. Can be left null to use the first source on the object.")]
	public AudioSource source;

	// Use this for initialization.
	protected void Start () {
		if (source == null) {
			source = GetComponent<AudioSource> ();
		}
	}

	// Checks if the player's collider is relevant in the event.
	bool isPlayerCollider(Collider collider) {
		if (collider.tag == "Player") {
			CharacterMotor player = collider.GetComponent<CharacterMotor> ();
			return collider != player.movement.characterCollider;
		} else {
			return false;
		}
	}

	// Triggers an effect when the player collides with the object.
	void OnTriggerEnter (Collider collider) {
		if (isPlayerCollider (collider)) {
			OnPlayerCollide (collider);
		}
	}

	// Triggers an effect when the player collides with the object.
	protected virtual void OnPlayerCollide (Collider collider) {
	}

	// Triggers an effect every tick that the player's collider is within the object.
	void OnTriggerStay (Collider collider) {
		if (isPlayerCollider (collider)) {
			OnPlayerCollideStay (collider);
		}
	}
	
	// Triggers an effect every tick that the player's collider is within the object.
	protected virtual void OnPlayerCollideStay (Collider collider) {
	}

	// Triggers an effect when the player's collider leaves the object.
	void OnTriggerExit (Collider collider) {
		if (isPlayerCollider (collider)) {
			OnPlayerCollideExit (collider);
		}
	}
	
	// Triggers an effect when the player's collider leaves the object.
	protected virtual void OnPlayerCollideExit (Collider collider) {
	}

	// Plays the sound in the audio source.
	public virtual void PlaySound () {
		if (source != null) {
			source.PlayOneShot (source.clip);
		}
	}
}

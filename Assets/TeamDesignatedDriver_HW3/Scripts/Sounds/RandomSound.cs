using UnityEngine;
using System.Collections;

// Plays a random sound selected from a bank of sounds.
public abstract class RandomSound : Sound {

	[Tooltip("All possible sounds to be played.")]
	public AudioClip[] sounds;

	// Plays the sound in the audio source.
	public override void PlaySound () {
		float randomValue = 1;
		do {
			randomValue = Random.value;
		} while (randomValue == 1);
		AudioClip randomSound = sounds [(int) (randomValue * sounds.Length)];
		source.PlayOneShot (randomSound);
	}
}
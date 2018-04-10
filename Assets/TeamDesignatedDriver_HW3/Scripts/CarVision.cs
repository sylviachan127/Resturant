using UnityEngine;
using System.Collections;

// Handles stopping the car when the player is in the way.
public class CarVision : MonoBehaviour {

	// The car component of the car.
	Car car;
	// The audio source attached to the car.
	AudioSource source;
	[Tooltip("Sound played when the player gets in the way.")]
	public AudioClip stopSound;

	// Use this for initialization.
	void Start () {
		car = GetComponentInParent<Car> ();
		source = GetComponentInParent<AudioSource> ();
	}
	
	// Stops the car and plays a sound when the player is spotted.
	void OnTriggerEnter (Collider collider) {
		if (collider.tag == "Player" && !car.stopped) {
			car.stopped = true;
			source.Stop ();
			source.PlayOneShot (stopSound);
		}
	}
	
	// Resumes car motion when the player gets out of the way.
	void OnTriggerExit (Collider collider) {
		if (collider.tag == "Player") {
			car.stopped = false;
			source.Play ();
		}
	}
}

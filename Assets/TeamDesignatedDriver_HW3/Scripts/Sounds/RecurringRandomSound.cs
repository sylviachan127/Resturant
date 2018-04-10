using UnityEngine;
using System.Collections;

// Random sound that plays at fixed intervals.
public class RecurringRandomSound : RandomSound {
		
	[Tooltip("The time (in seconds) after the sound stops before it starts again.")]
	public float timeDelay = 0;
	// Timer to keep track of when to play the sound.
	int timer = 0;
	
	// Update is called once per frame.
	void Update () {
		if (!source.isPlaying) {
			if (timer++ > timeDelay * 60) {
				timer = 0;
				PlaySound ();
			}
		}
	}
}
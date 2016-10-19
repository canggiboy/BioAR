using UnityEngine;
using System.Collections;

public class backgroundAudio : MonoBehaviour {

	public AudioSource myAudioSource;

	public static GameObject bgObject;

	void Awake()
	{
		if (bgObject) 
		{
			Destroy (gameObject);
			return;
		}

		myAudioSource.Play ();
		bgObject = gameObject;
	}
}

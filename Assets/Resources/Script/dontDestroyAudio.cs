using UnityEngine;
using System.Collections;

public class dontDestroyAudio : MonoBehaviour {

	void Awake (){
		DontDestroyOnLoad (gameObject);
	}

}
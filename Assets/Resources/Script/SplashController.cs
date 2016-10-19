using UnityEngine;
using System.Collections;

public class SplashController : MonoBehaviour {

	void Start() {
		StartCoroutine (Example());
	}
	
	IEnumerator Example() {
		yield return new WaitForSeconds(2);
		Application.LoadLevel ("mainMenu");
	}
}

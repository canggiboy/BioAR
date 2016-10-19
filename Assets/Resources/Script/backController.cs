using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class backController : MonoBehaviour {

	public LoadSceneMode loadMode = LoadSceneMode.Single;

	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			SceneManager.LoadScene("mainMenu");
			return;
		} 
		else if (Input.GetKey (KeyCode.Menu)) {
			SceneManager.LoadScene("mainMenu");
		}
	}
}
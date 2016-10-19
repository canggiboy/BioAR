using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

namespace sceneTute
{
	public class gameScene : MonoBehaviour {

		public LoadSceneMode loadMode = LoadSceneMode.Single;

		public void loadScene(string sceneName)
		{
			SceneManager.LoadScene (sceneName, loadMode);
		}

		public void loadScene(int sceneIndex)
		{
			SceneManager.LoadScene (sceneIndex, loadMode);
		}
	}
}
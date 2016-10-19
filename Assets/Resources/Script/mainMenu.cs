using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

	public void GoToMainMenu()
	{
		Application.LoadLevel ("mainMenu");
	}

	public void GoToARCamera()
	{
		Application.LoadLevel ("Virus-CloudReco");
	}

	public void GoToSetting()
	{
		Application.LoadLevel ("settingMenu");
	}

	public void GoToAbout()
	{
		Application.LoadLevel ("aboutMenu");
	}

	public void GoToHelp()
	{
		Application.LoadLevel ("helpMenu");
	}

}

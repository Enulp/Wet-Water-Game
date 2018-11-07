using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Multi: MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Tuto Multi");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

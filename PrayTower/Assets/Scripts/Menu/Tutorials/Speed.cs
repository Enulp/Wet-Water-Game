using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Speed: MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Speed Tuto");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clone: MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Clone Tuto");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

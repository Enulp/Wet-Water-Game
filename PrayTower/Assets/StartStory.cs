using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartStory : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Intro");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

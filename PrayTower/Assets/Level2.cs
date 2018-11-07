using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2 : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 2");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2M : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 2M");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

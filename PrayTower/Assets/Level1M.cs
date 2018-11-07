using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1M : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 1M");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

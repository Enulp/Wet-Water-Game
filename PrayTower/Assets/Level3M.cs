using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3M : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 3M");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

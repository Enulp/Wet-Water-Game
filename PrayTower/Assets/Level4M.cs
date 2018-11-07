using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4M : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 4M");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4 : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 4");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

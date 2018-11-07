using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5M : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 5M");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

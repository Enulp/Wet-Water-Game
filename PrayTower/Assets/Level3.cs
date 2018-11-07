using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3 : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Level 3");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Telekinesis : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Telekinesis Tuto");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

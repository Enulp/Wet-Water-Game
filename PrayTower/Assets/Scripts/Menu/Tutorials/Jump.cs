using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jump : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Jump Tuto");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

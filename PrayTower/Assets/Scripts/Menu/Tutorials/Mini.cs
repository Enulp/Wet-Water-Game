using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mini : MonoBehaviour {

	public void PlayGame ()
	{
		SceneManager.LoadScene ("Mini Tuto");
	}

	public void QuitGame ()
	{
		Application.Quit();
	}

}

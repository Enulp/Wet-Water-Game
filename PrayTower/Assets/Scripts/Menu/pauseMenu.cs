using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (GameIsPaused) {
				Resume ();
			} 
			else 
			{
				Pause ();
			}
				
		}

	}

	public void Resume()
	{
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
		Cursor.visible = false;
	}

	void Pause()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		Cursor.visible = true;
	}

	public void LoadMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Menu");
	}

	public void LoadLvl2()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 2");
	}

	public void LoadLvl3()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 3");
	}

	public void LoadLvl4()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 4");
	}

	public void LoadLvl5()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 5");
	}

	public void LoadLvl2M()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 2M");
	}

	public void LoadLvl3M()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 3M");
	}

	public void LoadLvl4M()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 4M");
	}

	public void LoadLvl5M()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Level 5M");
	}

	public void LoadConclusion()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("Conclusion");
	}

	public void QuitGame()
	{
		Application.Quit ();
	}
}

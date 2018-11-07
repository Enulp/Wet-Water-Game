using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Level5 : MonoBehaviour {

    public void PlayGame ()
    {
        SceneManager.LoadScene ("Level 5");
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

}

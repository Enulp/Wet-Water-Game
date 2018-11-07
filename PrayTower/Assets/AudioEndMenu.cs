using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEndMenu : MonoBehaviour {


	public AudioClip KittID;

	// Use this for initialization
	void Start () {
		StartCoroutine(LoadKittID("MainScreen"));
	}

	IEnumerator LoadKittID(string level01){
		yield return new WaitForSeconds(2.0f); // wait time
		GetComponent<AudioSource>().PlayOneShot(KittID);

		yield return new WaitForSeconds(20.0f);

		Application.LoadLevel("Menu");
	}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevel : MonoBehaviour {

	public GameObject EndLevelUI;

	// Use this for initialization
	void OnTriggerEnter (Collider col)
	{
		if (col.CompareTag ("Player"))
		{
			EndLevelUI.SetActive (true);
			Time.timeScale = 0f;
			Cursor.visible = true;
		} 
	}
}

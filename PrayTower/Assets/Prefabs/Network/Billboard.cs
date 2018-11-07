using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{

	public GameObject CameraLookAt;
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(CameraLookAt.transform);
	}
}

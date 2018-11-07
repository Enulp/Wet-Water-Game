using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MM: MonoBehaviour 
{
	public float multiplier = 0.3f;
	public Transform Camera;
	public GameObject powerUIimage;

	public GameObject pickupEffect;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			Pickup(other);
			powerUIimage.SetActive (true);
		}
	}

	void Pickup(Collider player)
	{
		Instantiate(pickupEffect, transform.position, transform.rotation);

		//Apply effect

		GameObject smokePuff = Instantiate(pickupEffect, transform.position, transform.rotation) as GameObject;
		float totalDuration = 1f; 
		player.transform.localScale *= multiplier;
		Vector3 ok = new Vector3 (player.transform.position.x, player.transform.position.y + 4, player.transform.position.z);
		player.transform.position = ok;
		Camera.GetComponent<Camera>().GetComponent<CameraController>().offset.y += 5;
		Camera.GetComponent<Camera>().GetComponent<CameraController>().offset.z -= 7;
		Destroy(smokePuff, totalDuration);
		Destroy(gameObject);
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DM : MonoBehaviour 
{
	public float multiplier = 0.5f;
	public GameObject pickupEffect;
	public GameObject powerUIimage;

	void OnTriggerEnter(Collider other) 
	{
		if (other.CompareTag ("Player"))
		{
			other.GetComponent<PlayerControllerMulti> ().hasDrunk = true;
			Pickup(other);
			powerUIimage.SetActive (true);
			StartCoroutine (MyCoroutine ());
			other.GetComponent<PlayerControllerMulti> ().hasDrunk = false;
		}
		StartCoroutine (MyCoroutine ());
	}

	IEnumerator MyCoroutine()
	{
		yield return new WaitForSeconds(10f);
	}

	void Pickup(Collider player)
	{
		//Instantiate(pickupEffect, transform.position, transform.rotation);

		//Apply effect
		GameObject smokePuff = Instantiate(pickupEffect, transform.position, transform.rotation) as GameObject;
		float totalDuration = 1f;
		Destroy(smokePuff, totalDuration);
		Destroy(gameObject);
	}


}
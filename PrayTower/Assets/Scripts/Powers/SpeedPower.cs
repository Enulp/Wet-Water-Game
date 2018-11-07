using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedPower: MonoBehaviour 
{
	public float multiplier = 0.5f;
	public GameObject pickupEffect;
	public GameObject powerUIimage;

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
		//Instantiate(pickupEffect, transform.position, transform.rotation);

		//Apply effect


		GameObject smokePuff = Instantiate(pickupEffect, transform.position, transform.rotation) as GameObject;
		float totalDuration = 1f;

		PlayerController x = player.GetComponent<PlayerController>();
		x.moveSpeed += multiplier * 20;
		Destroy(smokePuff, totalDuration);
		Destroy(gameObject);
	}
}

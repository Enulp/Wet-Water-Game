using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyPenalty: MonoBehaviour 
{
	public float multiplier = 0.5f;

	public GameObject pickupEffect;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player"))
		{
			Pickup(other);
		}
	}

	void Pickup(Collider player)
	{
		//Instantiate(pickupEffect, transform.position, transform.rotation);

		//Apply effect
		GameObject smokePuff = Instantiate(pickupEffect, transform.position, transform.rotation) as GameObject;
		float totalDuration = 1f;

		PlayerController x = player.GetComponent<PlayerController>();
		x.jumpForce -= multiplier * 10;
		x.moveSpeed -= multiplier * 10;
		Destroy(smokePuff, totalDuration);
		Destroy(gameObject);
	}
}

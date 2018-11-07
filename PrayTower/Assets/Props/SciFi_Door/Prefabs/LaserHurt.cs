using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserHurt : MonoBehaviour {

	public int damageToGive = 1;

	// Use this for initialization
	void Start () {

	}

	//Update is called once per frame
	void Update () {

	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.GetComponent<PlayerController> ().hasDrunk = false;
			Vector3 hitDirection = other.transform.position - transform.position;
			hitDirection = hitDirection.normalized;
			FindObjectOfType<HealthManager>().HurtPlayer(damageToGive, hitDirection);

		}
	}
}
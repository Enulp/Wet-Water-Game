using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {

	public Transform respawnPoint;
	public Transform spawnPoint;
	public Transform prefab;
	public Transform player;


	IEnumerator WaitASec()
	{
		yield return new WaitForSecondsRealtime(1);
	}

	void OnTriggerEnter(Collider other) 
	{
		// ClonePower
		if (other.CompareTag ("Player") && other.GetComponent<PlayerController> ().hasClone) 
		{
			Instantiate (prefab, spawnPoint.position, spawnPoint.rotation);
			StartCoroutine(WaitASec ());
		}
			
		//Death -> Respawn
		else if (other.CompareTag ("Player")) 
		{
			Instantiate (player, respawnPoint.position, respawnPoint.rotation);
			Destroy(other.gameObject);
		}

		
	}
}

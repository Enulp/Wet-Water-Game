using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterHurtMulti : MonoBehaviour {

	public int damageToGive;

	public GameObject _player;
	
	public float water = - 0.5f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Health health = _player.GetComponent<Health>();
		
		if (_player.transform.position.y < water)
		{
			health.TakeDamage(damageToGive);
		}
	}

	
	
	
}

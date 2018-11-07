using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneHover : MonoBehaviour {
	public GameObject Drone;
	public float speed;
	public float verticalSpeed;
	public float amplitude;

	private Vector3 tempPosition;

	void FixedUpdate () 
	{
		
		OrbitAround();
		tempPosition = transform.position;
		tempPosition.y = Mathf.Sin (Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
		transform.position = tempPosition;
	}

	void OrbitAround()
	{
		transform.RotateAround(Drone.transform.position, Vector3.up, speed * Time.deltaTime);

	}
}
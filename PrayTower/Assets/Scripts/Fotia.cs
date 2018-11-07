using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fotia : MonoBehaviour {

	public GameObject Drone;
	public float speed;
	public float verticalSpeed;
	public float amplitude;
    public int a;
	private Vector3 tempPosition;

	void Update () 
	{
		tempPosition = transform.position;
		tempPosition.z = Drone.transform.localPosition.z + Random.Range (-20, 20);
		tempPosition.x = Drone.transform.localPosition.x + Random.Range (-15 * Mathf.Sin(45), 15 * Mathf.Sin(45));
		tempPosition.y = Drone.transform.localPosition.y + Random.Range (0, 15) -2;
		transform.position = Vector3.Lerp (transform.position, tempPosition, Time.deltaTime);
	}
}

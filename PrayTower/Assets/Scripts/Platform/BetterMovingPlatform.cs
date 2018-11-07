using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetterMovingPlatform : MonoBehaviour {

	public Transform movingPlatform;
	public Transform startTranform;
	public Transform endTranform;
	public Vector3 newPosition;
	public string currentState;
	public float smooth;
	public float resetTime;

	void Start()
	{
		ChangeTarget (); 
	}

	void FixedUpdate()
	{
		movingPlatform.position = Vector3.Lerp (movingPlatform.position, newPosition, smooth * Time.deltaTime);
	}

	void ChangeTarget()
	{
		if (currentState == "Moving To Start Position") 
		{
			currentState = "Moving To End Position";
			newPosition = endTranform.position;
		}
		else if(currentState == "Moving To End Position") 
		{
			currentState = "Moving To Start Position";
			newPosition = startTranform.position;
		}
		else if(currentState == "") 
		{
			currentState = "Moving To End Position";
			newPosition = endTranform.position;
		}
		Invoke ("ChangeTarget", resetTime);
	}
}
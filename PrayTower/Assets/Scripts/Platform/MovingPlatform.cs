using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour {

	[SerializeField]
	Transform platform;
	[SerializeField]
	Transform startTranform;
	[SerializeField]
	Transform endTranform;
	[SerializeField]
	float moveSpeed;

	Vector3 direction;
	Transform destination;

	void Start()
	{
		SetDestination (startTranform);
	}

	void FixedUpdate()
	{
		platform.GetComponent<Rigidbody>().MovePosition(platform.position + direction * moveSpeed * Time.fixedDeltaTime);
		if (Vector3.Distance (platform.position, destination.position) < moveSpeed * Time.fixedDeltaTime)
			SetDestination (destination == startTranform ? endTranform : startTranform);
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (startTranform.position, platform.localScale);
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (endTranform.position, platform.localScale);
	}

	void SetDestination(Transform dest)
	{
		destination = dest;
		direction = (destination.position - platform.position).normalized;
	}
}

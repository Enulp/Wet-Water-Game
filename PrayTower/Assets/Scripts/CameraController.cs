using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	public bool useOffsetValues;
	public float rotateSpeed;
	public Transform pivot;
	public float maxViewAngle;
	public float minViewAngle;
	public bool invertY;

	// Use this for initialization
	void Start () {
		if (!useOffsetValues) 
		{
			offset = target.position - transform.position;
		}

		pivot.transform.position = target.transform.position;
		//pivot.transform.parent = target.transform;
		pivot.transform.parent = null;

		//Hide Cursor
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
		pivot.transform.position = target.transform.position;

		//Get x position of the mouse & rotate the target
		float horizontal = Input.GetAxisRaw("Mouse X") * rotateSpeed;
		pivot.Rotate(0, horizontal, 0);

		//Get y position of the mouse & rotate the pivot
		float vertical = Input.GetAxisRaw("Mouse Y") * rotateSpeed;
		if(invertY)
			pivot.Rotate (vertical, 0, 0);
		else
			pivot.Rotate (-vertical, 0, 0);

		//Limit the up down cam position
		if (pivot.rotation.eulerAngles.x > maxViewAngle && pivot.rotation.eulerAngles.x < 180f) 
		{
			pivot.rotation = Quaternion.Euler (maxViewAngle, 0, 0);
		}

		if (pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 360f + minViewAngle) 
		{
			pivot.rotation = Quaternion.Euler (minViewAngle, 0, 0);
		}


		//Move the camera based on the current position of the target & the original offset
		float desiredYAngle = pivot.eulerAngles.y;
		float desiredXAngle = pivot.eulerAngles.x;
		Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
		transform.position = target.position - (rotation * offset);

		//transform.position = target.position - offset;

		if (transform.position.y < target.position.y) {
			transform.position = new Vector3 (transform.position.x, target.position.y - .5f, transform.position.z);
		}

		transform.LookAt(target);
	}
}

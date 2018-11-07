﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdMoveObject : MonoBehaviour {

	public GameObject item;
	public GameObject tempParent;
	public Transform guide;
	bool carrying;
	public float range = 2;

	void Start()
	{
		item.GetComponent<Rigidbody>().useGravity = true;
	}
	// Update is called once per frame
	void Update()
	{
		if (carrying == false)
		{
			if (Input.GetKeyDown(KeyCode.Mouse0) && (guide.transform.position - transform.position).sqrMagnitude < range * range) 
			{
				pickup();
				carrying = true;
			}
		}
		else if (carrying == true)
		{
			if (Input.GetKeyDown(KeyCode.Mouse0))
			{
				drop();
				carrying = false;
			}
		}
	}
	void pickup()
	{
		item.GetComponent<Rigidbody>().useGravity = false;
		item.GetComponent<Rigidbody>().isKinematic = true;
		item.transform.position = guide.transform.position;
		item.transform.rotation = guide.transform.rotation;
		item.transform.parent = tempParent.transform;
	}
	void drop()
	{
		item.GetComponent<Rigidbody>().useGravity = true;
		item.GetComponent<Rigidbody>().isKinematic = false;
		item.transform.parent = null;
		item.transform.position = guide.transform.position;
		Vector3 ok = new Vector3 (guide.transform.position.x, guide.transform.position.y + 2, guide.transform.position.z);
		item.transform.position = ok;
	}
}

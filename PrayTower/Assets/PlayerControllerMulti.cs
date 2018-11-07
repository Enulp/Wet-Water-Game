using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControllerMulti : NetworkBehaviour {

	public bool hasClone = false;
	public bool hasDrunk = false;

	public float moveSpeed;
	//public Rigidbody theRB;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveDirection;
	public float gravityScale;

	public Animator anim;
	public Transform pivot;
	public float rotateSpeed;

	public GameObject playerModel;
	public GameObject bulletPrefab;
	public Transform spawnbullet;

	// Use this for initialization
	void Start () {
		//theRB = GetComponent<Rigidbody> ();
		controller = GetComponent<CharacterController>();
	}

	
	// Update is called once per frame
	void Update () {
		/*theRB.velocity = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
		if(Input.GetButtonDown("Jump")) 
		{
			theRB.velocity = new Vector3 (theRB.velocity.x, jumpForce, theRB.velocity.z);
		}
		*/
		
		if (!isLocalPlayer)
		{
			return;
		}

		//moveDirection = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
		float yStore = moveDirection.y;
		if (hasDrunk) {
			moveDirection = (transform.forward * Input.GetAxisRaw ("Vertical")) + (transform.right * Input.GetAxisRaw ("Horizontal"));
			moveDirection = -moveDirection.normalized * moveSpeed;
			moveDirection.y = yStore;
		} 
		else {
			moveDirection = (transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"));
			moveDirection = moveDirection.normalized * moveSpeed;
			moveDirection.y = yStore;
		}



		if(controller.isGrounded)
		{
			moveDirection.y = 0f;
			if(Input.GetButtonDown("Jump"))
			{
				moveDirection.y = jumpForce;
			}
		}
		moveDirection.y += Physics.gravity.y * gravityScale * Time.deltaTime; 
		controller.Move(moveDirection * Time.deltaTime);

		//Move the player in different directions based on camera look direction
		if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0) 
		{
			transform.rotation = Quaternion.Euler (0f, pivot.rotation.eulerAngles.y, 0f);
			Quaternion newRotation = Quaternion.LookRotation (new Vector3 (moveDirection.x, 0f, moveDirection.z));
			playerModel.transform.rotation = Quaternion.Slerp (playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
		}

		//anim.SetBool ("isGrounded", controller.isGrounded);
		//anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxisRaw("Vertical")) + Mathf.Abs(Input.GetAxisRaw("Horizontal"))));
		
		if (Input.GetKeyDown((KeyCode.Mouse1)))
		{
			CmdFire();
		}
	}

	[Command]
	void CmdFire()
	{
		var bullet = (GameObject) Instantiate(bulletPrefab, spawnbullet.position, spawnbullet.rotation);

		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 40;

		NetworkServer.Spawn (bullet);

		Destroy(bullet, 5.0f);
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerController : MonoBehaviour {

	public float moveSpeed;
	//public Rigidbody theRB;
	public float jumpForce;
	public CharacterController controller;

	private Vector3 moveDirection;
	public float gravityScale;


	public GameObject playerModel;

	void Start () {
		//theRB = GetComponent<Rigidbody> ();
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void LateUpdate () {
		/*theRB.velocity = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, theRB.velocity.y, Input.GetAxis("Vertical") * moveSpeed);
		if(Input.GetButtonDown("Jump")) 
		{
			theRB.velocity = new Vector3 (theRB.velocity.x, jumpForce, theRB.velocity.z);
		}
		*/

		//moveDirection = new Vector3 (Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, Input.GetAxis("Vertical") * moveSpeed);
		float yStore = moveDirection.y;
		moveDirection = (transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"));
		moveDirection = moveDirection.normalized * moveSpeed;
		moveDirection.y = yStore;

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

		//anim.SetBool ("isGrounded", controller.isGrounded);
		//anim.SetFloat("Speed", (Mathf.Abs(Input.GetAxisRaw("Vertical")) + Mathf.Abs(Input.GetAxisRaw("Horizontal"))));
	}
}

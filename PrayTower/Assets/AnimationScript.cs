using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {

    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.D))
            anim.SetBool("Walking", true);
        else
            anim.SetBool("Walking", false);

        if (Input.GetKeyDown(KeyCode.Space))
            anim.SetBool("Jumping", true);
        else
            anim.SetBool("Jumping", false);
    }
}

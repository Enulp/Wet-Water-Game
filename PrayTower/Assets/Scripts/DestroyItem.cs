using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour {

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    float lifetime = 2.0f;

    public void DestroyExplosion()
    {
        Destroy(gameObject, lifetime);
    }
}

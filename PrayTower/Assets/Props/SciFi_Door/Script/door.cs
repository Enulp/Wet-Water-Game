using UnityEngine;
using System.Collections;

public class door : MonoBehaviour {
	GameObject thedoor;
	bool isopen;
	public GameObject doorbase;

	void OnTriggerEnter ( Collider obj  ){
		if (obj.gameObject.tag == "Pickup") 
		{
			doorbase.GetComponent<Animation>().Play("open");
			//isopen = true;
		}
}

	void OnTriggerExit ( Collider obj  ){
		if (obj.gameObject.tag == "Pickup")
		{
			doorbase.GetComponent<Animation>().Play("close");
			isopen = false;
		}
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			doorbase.GetComponent<Animation>().Play("open");
		}
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			doorbase.GetComponent<Animation>().Play("open");
		}
	}

}

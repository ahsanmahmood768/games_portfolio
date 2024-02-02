using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cim_Jarrey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W)) {
			GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (0, 0, 0.05f));
		}
		if (Input.GetKey (KeyCode.A)) {
			GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (-0.05f, 0, 0));
		}
		if (Input.GetKey (KeyCode.S)) {
			GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (0, 0, -0.05f));
		}
		if (Input.GetKey (KeyCode.D)) {
			GetComponent<Rigidbody> ().MovePosition (transform.position + new Vector3 (0.05f, 0, 0));
		}
	}
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

	private Rigidbody my_Rigidbody;
	// Use this for initialization
	void Start () {
		my_Rigidbody = GetComponent<Rigidbody> ();
		print (Physics.gravity);

	}
	
	// Update is called once per frame
	void Update () {
		print (Time.time);
		if (Input.GetKey (KeyCode.W)) {
			my_Rigidbody.AddForce (new Vector3 (0, 0, 1f), ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.A)) {
			my_Rigidbody.AddForce (new Vector3 (-1f, 0, 0), ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.S)) {
			my_Rigidbody.AddForce (new Vector3 (0, 0, -1f), ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.D)) {
			my_Rigidbody.AddForce (new Vector3 (1f, 0, 0), ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.Space)) {
			my_Rigidbody.AddForce (new Vector3 (0, 2f, 0), ForceMode.VelocityChange);
		}
	}
}
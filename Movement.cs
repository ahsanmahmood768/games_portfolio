using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour {

    //Movement bools
    private bool wPressed;
    private bool sPressed;

    //Rotation bools
    private bool aPressed;
    private bool dPressed;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Track inputs
        wPressed = Input.GetKey(KeyCode.W);
        sPressed = Input.GetKey(KeyCode.S);
        aPressed = Input.GetKey(KeyCode.A);
        dPressed = Input.GetKey(KeyCode.D);
    }

    private void FixedUpdate()
    {
        //Physics
        if(wPressed == true)
        {
            transform.position += transform.forward * speed;
        }

        if (sPressed == true)
        {
            transform.position -= transform.forward * speed;
        }

        if (aPressed == true)
        {
            transform.Rotate(-transform.up);
        }

        if (dPressed == true)
        {
            transform.Rotate(transform.up);
        }
    }

    private void OnCollisionEnter(Collision collidedObject)
    {
        if (collidedObject.gameObject.tag == "Win_condition")
        {
            print("WIN");
            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    private bool canFire;
    private float lastFireTime;
    public float fireInterval;
    public GameObject bulletPrefab;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time - lastFireTime > fireInterval)
        {
            canFire = true;
        }
	}

    private void FixedUpdate()
    {
        if(canFire == true)
        {
            fire();
            canFire = false;
        }
    }

    private void fire()
    {
        lastFireTime = Time.time;
        Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}

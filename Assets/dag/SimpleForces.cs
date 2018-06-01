using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleForces : MonoBehaviour {

    public float speed = 10.0f;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour {

    public float speed = 10.0f;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();


	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(Vector3.right * speed);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A02Examples
{
    public class BallController : MonoBehaviour
    {
        public float speed = 10.0f;

        Rigidbody rb;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 dir = new Vector3(moveX, 0.0f, moveZ);

            rb.AddForce(dir * speed);
        }
    }
}
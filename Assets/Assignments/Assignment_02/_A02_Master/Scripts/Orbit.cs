using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A02Examples
{
    public class Orbit : MonoBehaviour
    {
        public Vector3 startDirection;
        public float gravity;

        public Transform centralBody;
        float centralMass;
        Rigidbody rb;

        // Use this for initialization
        void Start()
        {
            rb = GetComponent<Rigidbody>();

            rb.AddForce(startDirection);
            centralMass = centralBody.GetComponent<Rigidbody>().mass;
        }

        void FixedUpdate()
        {
            Vector3 dir = centralBody.position - transform.position;
            float dist = dir.sqrMagnitude;

            dir.Normalize();

            rb.AddForce((rb.mass + centralMass)/dist * dir);
        }
    }
}
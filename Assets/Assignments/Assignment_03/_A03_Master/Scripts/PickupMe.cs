using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A03Examples
{
    public class PickupMe : MonoBehaviour
    {
        public bool grabbed = false;
        Rigidbody myRb;
        StrobeSelected strobe;

        // Use this for initialization
        void Start()
        {
            myRb = GetComponent<Rigidbody>();
            strobe = GetComponent<StrobeSelected>();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PickupOrDrop()
        {
            if (grabbed)
            {  // now drop it
                transform.parent = null;
                grabbed = false;
                myRb.isKinematic = false;  //    .useGravity = true;
                strobe.trigger = false;
            }
            else
            {
                transform.parent = Camera.main.transform;
                grabbed = true;
                strobe.trigger = true;
                myRb.isKinematic = true; //  .useGravity = false;
            }
        }
    }
}

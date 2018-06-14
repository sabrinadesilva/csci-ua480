using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A03Examples
{
    public class SceneManager : MonoBehaviour
    {

        public bool grabbed = false;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void PickupOrDrop() {
            if (grabbed) {
                transform.parent = null;
                grabbed = false;
            } else {
                transform.parent = Camera.main.transform;
                grabbed = true;
            }
        }
    }
}
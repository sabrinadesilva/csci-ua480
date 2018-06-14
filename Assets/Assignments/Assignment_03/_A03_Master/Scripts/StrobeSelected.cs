using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace A03Examples
{
    public class StrobeSelected : MonoBehaviour
    {

        public bool trigger = false;
        public Color strobeColor = Color.red;
        public float strobeSpeed = 12;

        Color initColor;
        bool prevTrigger = false;

        void Start()
        {
            initColor = this.GetComponent<MeshRenderer>().material.color;
        }

        void Update()
        {

            HandleTrigger();
        }

        void HandleTrigger()
        {

            if (trigger)
            {
                Strobe();
            }

            if (!trigger && prevTrigger)
            {
                this.GetComponent<MeshRenderer>().material.color = initColor;
            }

            prevTrigger = trigger;

        }

        void Strobe()
        {
            this.GetComponent<MeshRenderer>().material.color =
                Color.Lerp(initColor, strobeColor, (Mathf.Sin(Time.time * strobeSpeed) + 1) * .5f);

        }
    }
}

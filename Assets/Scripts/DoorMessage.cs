using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs {
    public class DoorMessage : MonoBehaviour
    {
        private PlayerInputs playerInputs;

        public Animator animator;

        public Canvas doorMessageCanvas;

        public bool enteredCollision;

        private void Awake()
        {
            playerInputs = FindObjectOfType<PlayerInputs>();            
        }

        private void Update()
        {
            if(enteredCollision)
            {
                playerInputs.OpenDoor(animator, doorMessageCanvas);
            }            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                enteredCollision = true;
                doorMessageCanvas.enabled = true;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                enteredCollision = true;
                doorMessageCanvas.enabled = false;
            }
        }
    }
}

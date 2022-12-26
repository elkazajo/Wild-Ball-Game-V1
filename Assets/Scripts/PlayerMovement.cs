using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        private Rigidbody playerRigidbody;

        public float speed;
        public float jumpForce;

        private bool isGrounded;

        void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MovePlayer(Vector3 movementDirection)
        {
            if (isGrounded)
                playerRigidbody.AddForce(movementDirection * speed);
        }

        public void Jump(Vector3 jumpDirection)
        {
            if(isGrounded)
                playerRigidbody.AddForce(jumpDirection * jumpForce);
            isGrounded = false;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }            
        }
    }
}

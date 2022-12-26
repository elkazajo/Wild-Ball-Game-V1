using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WildBall.Inputs
{
    public class PlayerInputs : MonoBehaviour
    {
        PlayerMovement playerMovement;
        
        Vector3 movementDirection;
        Vector3 jumpDirection;

        private bool ballPushed;

        void Start()
        {
            playerMovement = GetComponent<PlayerMovement>();
        }

        
        void Update()
        {
            MovemementInputs();
            Jump();
        }

        private void FixedUpdate()
        {
            playerMovement.MovePlayer(movementDirection);            
        }

        void MovemementInputs()
        {
            float horizontalInput = Input.GetAxis(GlobalVariables.HORIZONTAL_AXIS);
            float verticalInput = Input.GetAxis(GlobalVariables.VERTICAL_AXIS);

            movementDirection = new Vector3(horizontalInput, GlobalVariables.ZERO, verticalInput).normalized;
            jumpDirection = new Vector3(GlobalVariables.ZERO, GlobalVariables.ONE, GlobalVariables.ZERO).normalized;
        }

        void Jump()
        {
            if (Input.GetButtonDown(GlobalVariables.JUMP_BUTTON))
            {                
                playerMovement.Jump(jumpDirection);                               
            }
        }
        
        public void OpenDoor(Animator animator, Canvas doorMessageCanvas)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                doorMessageCanvas.enabled = false;

                if (!animator.GetBool("EButtonPressed"))
                {
                    animator.SetBool("EButtonPressed", true);
                }
            }
        }
    }
}

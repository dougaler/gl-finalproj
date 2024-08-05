using System;
using UnityEngine;

namespace _app.scripts
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Movement Variables")] 
        public float movementSpeed;

        public Vector3 movementVector;
        public Vector3 jumpForce;
        public bool crouching;

        [Header("Player Components")] 
        public Rigidbody rb;
        public Camera playerCamera;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            
        }
        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerJump();
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                movementVector.z = 1;
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                movementVector.z = -1;
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                movementVector.x = 1;
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                movementVector.x = -1;
            }

            PlayerMovement();
            if (Input.GetKeyDown(KeyCode.Space))
            {
                GameManager.instance.playerScore++;
            }
        }

        private void PlayerJump()
        {
            rb.AddForce(jumpForce);
        }

        private void PlayerMovement()
        {
            transform.Translate(new Vector3(movementVector.x,movementVector.y,movementVector.z) * (movementSpeed * Time.deltaTime));
        }
    }
}
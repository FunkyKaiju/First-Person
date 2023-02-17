using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AuraVision.Bryan.FPS.CCC
{
    public class PlayerCamera : MonoBehaviour

    {
        [SerializeField] private Transform player;
        [SerializeField] private float mouseSensitivity = 2f;
        [SerializeField] private float cameraVerticalRotation = 0f;

        [SerializeField] private bool lockedCursor = true;



        private void Start()
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


        private void Update()
        {
            float inputX = Input.GetAxis("Mouse X") * mouseSensitivity;
            float inputY = Input.GetAxis("Mouse Y") * mouseSensitivity;

            cameraVerticalRotation -= inputY;
            cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
            transform.localEulerAngles = Vector3.right * cameraVerticalRotation;

            player.Rotate(Vector3.up * inputX);
            
        }

    }
}



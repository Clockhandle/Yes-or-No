using SUPERCharacter;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChange : MonoBehaviour
{
    public SUPERCharacterAIO playerController;


    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera laptopViewCamera;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            CameraTransition();
        }
    }

    void CameraTransition()
    {
        RaycastHit h;
        if (Physics.SphereCast(playerCamera.transform.position, 0.25f, playerCamera.transform.forward, out h, playerController.interactRange, 
            playerController.interactableLayer, QueryTriggerInteraction.Ignore))
        {
            IInteractable i = h.collider.GetComponent<IInteractable>();
            if (i != null)
            {
                laptopViewCamera.Priority = 40;
                playerController.enableMovementControl = false;
                playerController.enableCameraControl = false;
                playerController.crosshairImg.gameObject.SetActive(false);
                
            }
        }
    }
}

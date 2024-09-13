using SUPERCharacter;
using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateChange : MonoBehaviour
{
    public SUPERCharacterAIO playerController;
    public GameObject player;
    public GameObject Laptop;

    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera laptopViewCamera;

    private void Start()
    {
        playerCamera = player.GetComponentInChildren<CinemachineVirtualCamera>();
        laptopViewCamera = Laptop.GetComponentInChildren<CinemachineVirtualCamera>();
    }
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
                int temp = 0;
                temp = playerCamera.Priority;
                playerCamera.Priority = laptopViewCamera.Priority;
                laptopViewCamera.Priority = temp;
                playerController.enableMovementControl = false;
                playerController.enableCameraControl = false;
                playerController.crosshairImg.gameObject.SetActive(false);
            }
        }
    }
}

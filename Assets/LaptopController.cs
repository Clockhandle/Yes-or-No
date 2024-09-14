using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using SUPERCharacter;
using UnityEngine;

public class LaptopController : MonoBehaviour, IInteractable
{
    public SUPERCharacterAIO playerController;

    public CinemachineVirtualCamera playerCamera;
    public CinemachineVirtualCamera laptopViewCamera;
    public bool Interact()
    {
        StartCoroutine(TransitioningStates());
        return false;
    }

    IEnumerator TransitioningStates()
    {
        laptopViewCamera.Priority = 40;
        playerController.crosshairImg.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.2f);
        Debug.Log("Activate Computer");
        playerController.enabled = false;
    }
}

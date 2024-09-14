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
<<<<<<< Updated upstream:Assets/LaptopController.cs
        Debug.Log("Activate Computer");
        playerController.interactRange = 0;
=======
        StartCoroutine(TransitioningStates());
>>>>>>> Stashed changes:Assets/Scripts/LaptopController.cs
        return false;
    }

    IEnumerator TransitioningStates()
    {
        laptopViewCamera.Priority = 40;
        yield return new WaitForSeconds(2);
        Debug.Log("Activate Computer");
        playerController.enabled = false;
    }
}

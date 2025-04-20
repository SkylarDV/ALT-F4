using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;

public class BlackoutOnGrab : MonoBehaviour
{
    public XRGrabInteractable grabInteractable; // The object that can be grabbed
    public Image blackoutImage; // The image that will turn the screen black

    private bool isGrabbed = false; // A flag to ensure the screen only turns black once

    void Start()
    {
        if (grabInteractable == null || blackoutImage == null)
        {
            Debug.LogError("Grab Interactable or Blackout Image is not assigned!");
            return;
        }

        // Make the blackout image invisible at the start
        blackoutImage.enabled = false;

        // Subscribe to the grab event
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
    }

    // Called when the object is grabbed
    private void OnGrabbed(XRBaseInteractor interactor)
    {
        if (!isGrabbed) // Only apply blackout once
        {
            blackoutImage.enabled = true; // Show the black screen
            isGrabbed = true; // Set the flag to prevent further changes
        }
    }
}

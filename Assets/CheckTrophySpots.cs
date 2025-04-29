using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class CheckWinCondition : MonoBehaviour
{
    public SnapToSpot goldCube;
    public SnapToSpot silverCube;
    public SnapToSpot bronzeCube;
    public GameObject finalCube; // Assign the FinalCube in Unity
    public XRGrabInteractable coatGrab; // Drag the Coat's XRGrabInteractable here
    private bool hasActivated = false; // To prevent repeating

    void Update()
    {
        if (goldCube.inCorrectPosition && silverCube.inCorrectPosition && bronzeCube.inCorrectPosition)
        {
            finalCube.SetActive(true); // Make the FinalCube appear
             if (coatGrab != null)
            {
                coatGrab.enabled = true; // Unlock grabbing the coat
            }
            hasActivated = true; // Only trigger once
        }
    }
}

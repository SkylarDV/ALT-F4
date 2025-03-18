using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapToSpot : MonoBehaviour
{
    public Transform correctSpot; // This is the public variable
    public float snapDistance = 0.2f; // How close it needs to be to snap
    public bool inCorrectPosition = false; // Track if it's placed correctly
    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    void Update()
    {
        if (!inCorrectPosition && Vector3.Distance(transform.position, correctSpot.position) < snapDistance)
        {
            transform.position = correctSpot.position; // Snap into place
            transform.rotation = correctSpot.rotation; // Align rotation
            inCorrectPosition = true;

            // Disable grabbing after it's placed correctly
            grabInteractable.enabled = false;
        }
    }
}

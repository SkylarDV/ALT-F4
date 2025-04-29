using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportOnGrab : MonoBehaviour
{
    public Transform teleportDestination; // Where to teleport
    public GameObject playerRig; // Player's rig (Camera Rig / XR Origin)

    private XRGrabInteractable grabInteractable;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        // Teleport the player
        if (playerRig != null && teleportDestination != null)
        {
            playerRig.transform.position = teleportDestination.position;
        }

        // Destroy this object
        Destroy(gameObject);
    }
}

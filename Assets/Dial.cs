using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Dial : MonoBehaviour
{
    public int currentValue = 0; // Stores the dial's number (0-9)
    private XRGrabInteractable grabInteractable;
    private Rigidbody rb;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        rb = GetComponent<Rigidbody>();

        // Ensure Rigidbody is set correctly
        rb.angularDrag = 10f; // Stops unnecessary spinning
        rb.constraints = RigidbodyConstraints.FreezePosition | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;

        grabInteractable.selectExited.AddListener(SnapToNearestNumber);
    }

    void SnapToNearestNumber(SelectExitEventArgs args)
    {
        // Get the current Y rotation
        float currentRotation = transform.localEulerAngles.y;

        // Snap to the nearest 36-degree increment (360° / 10 numbers = 36° per step)
        float snappedRotation = Mathf.Round(currentRotation / 36f) * 36f;

        // Apply snapped rotation
        transform.localEulerAngles = new Vector3(0, snappedRotation, 0);

        // Convert snapped rotation into a number (0-9)
        currentValue = Mathf.RoundToInt(snappedRotation / 36f) % 10;

        Debug.Log(gameObject.name + " set to: " + currentValue); // Debug to check numbers in Console
    }
}

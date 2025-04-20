using UnityEngine;

public class CoatHangerTrigger : MonoBehaviour
{
    public GameObject coat1; // Grabbable coat
    public GameObject coat2; // Hung coat
    public Light roomLight; // Light to dim
    public GameObject materialObject; // Object to change material
    public Material newMaterial; // New material to apply
    public GameObject item1; // First item to launch
    public GameObject item2; // Second item to launch
    public float verticalLaunchForce = 10f; // Upward force (Y-axis)
    public float zLaunchForce = -5f; // Negative value for west (left) on the Z-axis

    private void OnTriggerEnter(Collider other)
    {
        // Check if coat1 is the object entering the trigger
        if (other.gameObject == coat1)
        {
            // Hide coat1
            coat1.SetActive(false);

            // Show coat2
            coat2.SetActive(true);

            // Dim the light (you can choose the value you want)
            if (roomLight != null)
            {
                roomLight.intensity = 0.3f; // Dim it
            }

            // Change material
            if (materialObject != null && newMaterial != null)
            {
                materialObject.GetComponent<Renderer>().material = newMaterial;
            }

            // Launch item1 and item2 in a diagonal direction
            LaunchObject(item1);  // Launch item1
            LaunchObject(item2);  // Launch item2
        }
    }

    // Method to apply force to the object and launch it
    private void LaunchObject(GameObject obj)
    {
        if (obj != null)
        {
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Create a launch direction using only Y (vertical) and Z (horizontal) forces
                // Negative Z-axis value for west (left)
                Vector3 launchDirection = new Vector3(0, verticalLaunchForce, zLaunchForce);  // No X-axis movement

                // Ensure Rigidbody is not kinematic (so it reacts to forces)
                rb.isKinematic = false;

                // Apply the force in the new diagonal direction
                rb.AddForce(launchDirection, ForceMode.Impulse);
            }
            else
            {
                Debug.LogWarning(obj.name + " does not have a Rigidbody attached.");
            }
        }
    }
}

using UnityEngine;

public class LockTrigger : MonoBehaviour
{
    public GameObject cabinetDoor; // Assign in Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            // Disable the cabinet door
            if (cabinetDoor != null)
            {
                cabinetDoor.SetActive(false);
            }
            else
            {
                Debug.LogWarning("Cabinet Door not assigned!");
            }

            // Disable the key
            other.gameObject.SetActive(false);
        }
    }
}

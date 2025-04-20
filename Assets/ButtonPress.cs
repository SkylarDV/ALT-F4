using UnityEngine;

public class RemoteButtonLogic : MonoBehaviour
{
    public GameObject planeToHide;
    public Transform remote;
    public float hideRange = 5f; // how close the remote needs to be

    public void OnButtonPressed()
    {
        float distance = Vector3.Distance(remote.position, planeToHide.transform.position);
        if (distance <= hideRange)
        {
            planeToHide.SetActive(false);
            Debug.Log("Plane hidden!");
        }
        else
        {
            Debug.Log("Too far to hide the plane.");
        }
    }
}

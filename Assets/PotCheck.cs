using UnityEngine;

public class PotTrigger : MonoBehaviour
{
    public GameObject objectToAppear; // drag the object you want to appear here

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pot")) // make sure the pot has the "Pot" tag!
        {
            objectToAppear.SetActive(true); // make the object appear
        }
    }
}

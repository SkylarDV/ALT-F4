using UnityEngine;

public class CombinationLock : MonoBehaviour
{
    public Dial dial1;  // Reference to first dial
    public Dial dial2;  // Reference to second dial
    public Dial dial3;  // Reference to third dial
    public GameObject lockedObject; // The cube that will disappear

    void Update()
    {
        // Check if the dials match the code 5-7-8
        if (dial1.currentValue == 5 && dial2.currentValue == 7 && dial3.currentValue == 8)
        {
            lockedObject.SetActive(false); // Hide the cube
        }
    }
}

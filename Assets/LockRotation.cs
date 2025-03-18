using UnityEngine;

public class LockDialRotation : MonoBehaviour
{
    void Update()
    {
        // Keep the dial upright by forcing X and Z rotation to stay at 0
        transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
    }
}

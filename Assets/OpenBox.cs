using UnityEngine;

public class CubeDisappear : MonoBehaviour
{
    public bool hitsKey = false; // This is our condition

    void Update()
    {
        if (hitsKey) // If hitsKey is true...
        {
            gameObject.SetActive(false); // Make the cube disappear
        }
    }
}

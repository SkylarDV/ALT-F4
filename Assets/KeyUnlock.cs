using UnityEngine;

public class CylinderFall : MonoBehaviour
{
    public GameObject cube;  // Assign the cube in Unity
    public GameObject key;   // Assign the key in Unity

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == cube) // If the cylinder touches the cube
        {
            cube.SetActive(false); // Make the cube disappear
            key.SetActive(false);  // Make the key disappear
            gameObject.SetActive(false); // Make the cylinder disappear
        }
    }
}

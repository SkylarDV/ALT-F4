using UnityEngine;

public class CheckWinCondition : MonoBehaviour
{
    public SnapToSpot goldCube;
    public SnapToSpot silverCube;
    public SnapToSpot bronzeCube;
    public GameObject finalCube; // Assign the FinalCube in Unity

    void Update()
    {
        if (goldCube.inCorrectPosition && silverCube.inCorrectPosition && bronzeCube.inCorrectPosition)
        {
            finalCube.SetActive(false); // Make the FinalCube disappear
        }
    }
}

using UnityEngine;

public class SearchController : MonoBehaviour
{
    public BeaconDetector detector;

    public float searchSpeed = 30f;

    void Update()
    {
        if (!detector.IsBeaconVisible)
        {
            transform.Rotate(
                0f,
                searchSpeed * Time.deltaTime,
                0f
            );

            Debug.Log("SEARCHING...");
        }
        else
        {
            Debug.Log("BEACON LOCKED");
        }
    }
}
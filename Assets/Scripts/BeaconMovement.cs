using UnityEngine;

public class BeaconMovement : MonoBehaviour
{
    void Update()
    {
        float x = Mathf.Sin(Time.time) * 3f;
        float y = Mathf.Cos(Time.time) * 2f;

        // Occasionally move beacon far outside the FOV
        if (Mathf.FloorToInt(Time.time) % 8 >= 6)
        {
            x = 10f;
            y = 7f;
        }

        transform.position = new Vector3(x, y, 5f);
    }
}
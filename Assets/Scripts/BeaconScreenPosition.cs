using UnityEngine;

public class BeaconScreenPosition : MonoBehaviour
{
    public Camera trackingCamera;
    public Transform beacon;

    void Update()
    {
        Vector3 screenPosition = trackingCamera.WorldToScreenPoint(beacon.position);

        if (Time.frameCount % 30 == 0)
        {
            Debug.Log("Beacon screen position: " + screenPosition);
        }
    }
}
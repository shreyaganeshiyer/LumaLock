using UnityEngine;

public class BeaconDetector : MonoBehaviour
{
    public Camera trackingCamera;
    public Transform beacon;

    public bool IsBeaconVisible { get; private set; }

    void Update()
    {
        Vector3 screenPosition =
            trackingCamera.WorldToScreenPoint(beacon.position);

        IsBeaconVisible =
            screenPosition.z > 0 &&
            screenPosition.x >= 0 &&
            screenPosition.x <= trackingCamera.pixelWidth &&
            screenPosition.y >= 0 &&
            screenPosition.y <= trackingCamera.pixelHeight;

        if (Time.frameCount % 30 == 0)
        {
            Debug.Log("Beacon Visible: " + IsBeaconVisible);
        }
    }
}
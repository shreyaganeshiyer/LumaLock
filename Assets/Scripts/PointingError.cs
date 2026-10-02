using UnityEngine;
using TMPro;

public class PointingError : MonoBehaviour
{
    public Camera trackingCamera;
    public Transform beacon;
    public TMP_Text telemetryText;
    private float timer = 0f;


    void Update()
    {
        Vector3 screenPosition =
            trackingCamera.WorldToScreenPoint(beacon.position);

        float centerX = trackingCamera.pixelWidth / 2f;
        float centerY = trackingCamera.pixelHeight / 2f;

        float errorX = screenPosition.x - centerX;
        float errorY = screenPosition.y - centerY;

        timer += Time.deltaTime;

        if (timer >= 0.1f)
        {
            telemetryText.text =
                $"ERROR X    {errorX:F1} px\n" +
                $"ERROR Y    {errorY:F1} px";

            timer = 0f;
        }
    }
}
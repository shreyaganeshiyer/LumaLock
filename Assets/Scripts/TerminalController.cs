using UnityEngine;

public class TerminalController : MonoBehaviour
{
    public Camera trackingCamera;
    public BeaconPredictor predictor;

    public float rotationSpeed = 50f;

    void Update()
    {
        Vector3 targetPosition = predictor.PredictedPosition;

        Vector3 screenPosition =
            trackingCamera.WorldToScreenPoint(targetPosition);

        if (screenPosition.z <= 0)
            return;

        float centerX = trackingCamera.pixelWidth / 2f;
        float centerY = trackingCamera.pixelHeight / 2f;

        float errorX = screenPosition.x - centerX;
        float errorY = screenPosition.y - centerY;

        float normalizedX = errorX / centerX;
        float normalizedY = errorY / centerY;

        transform.Rotate(
            -normalizedY * rotationSpeed * Time.deltaTime,
            normalizedX * rotationSpeed * Time.deltaTime,
            0f
        );
    }
}
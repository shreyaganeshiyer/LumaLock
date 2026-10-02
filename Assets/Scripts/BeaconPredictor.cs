using UnityEngine;

public class BeaconPredictor : MonoBehaviour
{
    public Transform beacon;
    public float predictionTime = 0.2f;

    private Vector3 previousPosition;
    private Vector3 velocity;

    public Vector3 PredictedPosition { get; private set; }

    void Start()
    {
        previousPosition = beacon.position;
    }

    void Update()
    {
        velocity = (beacon.position - previousPosition) / Time.deltaTime;

        previousPosition = beacon.position;

        PredictedPosition = beacon.position + velocity * predictionTime;

        if (Time.frameCount % 30 == 0)
        {
            Debug.Log("Actual: " + beacon.position +
                      " | Predicted: " + PredictedPosition);
        }
    }
}
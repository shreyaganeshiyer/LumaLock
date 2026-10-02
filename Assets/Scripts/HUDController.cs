using UnityEngine;
using TMPro;

public class HUDController : MonoBehaviour
{
    public BeaconDetector detector;
    public TMP_Text statusText;
    public TMP_Text beaconStatusText;

    void Update()
    {
        if (detector.IsBeaconVisible)
        {
            statusText.text = "● TRACKING";
            beaconStatusText.text = "BEACON LOCKED";
        }
        else
        {
            statusText.text = "● SEARCHING";
            beaconStatusText.text = "BEACON LOST";
        }
    }
}
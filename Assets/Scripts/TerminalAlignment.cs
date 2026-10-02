using UnityEngine;

public class TerminalAlignment : MonoBehaviour
{
    public Transform beacon;

    void Update()
    {
        Vector3 direction = beacon.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);
    }
}